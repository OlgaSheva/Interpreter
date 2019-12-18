using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInteractiveInterpreter
{
    public class Interpreter
    {
        public static ICollection<Variable> Variables = new List<Variable>();

        private Parser Parser = new Parser();

        public void Run()
        {
            while (true)
            {
                Console.Write(">");
                var data = Console.ReadLine();
                var result = Parser.Parse(data);
                var res = Execute(result);
                Console.WriteLine("\t" + res);
            }
        }

        private string Execute(Result result)
        {
            if (result.Op == "=")
            {
                var var = Variables.FirstOrDefault(val => val.Name == result.Variable.Name);
                if (var is null)
                {
                    Variables.Add(new Variable
                    {
                        Name = result.Variable.Name,
                        Value = result.Value
                    });
                }
                else
                {
                    var.Value = result.Value;
                }
                return result.Value.ToString();
            }
            else
            {
                var var = Variables.FirstOrDefault(val => val.Name == result.Variable.Name);
                if (var is null)
                {
                    return $"ERROR: Invalid identifier. No variable with name '{result.Variable.Name}' was found.";
                }
                if (result.SecondVariable is null)
                {
                    return (result.Operator.Execute(var.Value, result.Value)).ToString();
                }
                else
                {
                    var var2 = Variables.FirstOrDefault(val => val.Name == result.SecondVariable.Name);
                    if (var2 is null)
                    {
                        return $"ERROR: Invalid identifier. No variable with name '{result.SecondVariable.Name}' was found.";
                    }
                    return (result.Operator.Execute(var.Value, var2.Value)).ToString();
                }
            }
        }
    }
}
