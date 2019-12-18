using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SimpleInteractiveInterpreter.Operations;
using SimpleInteractiveInterpreter.Operators;

namespace SimpleInteractiveInterpreter
{
    public class Parser
    {
        public Result Parse(string data)
        {
            data.Replace(">", "");

            if (data.Contains('='))
            {
                var ass = ParseAssignment(data);
            }

            var datas = data.Split(' ');

            var val = 0;
            Variable secVar = null;

            if (!int.TryParse(datas[2].Trim(), out val)) {
                secVar = new Variable { Name = datas[2].Trim() };
            }

            return new Result { 
                Variable = new Variable { Name = datas[0].Trim() },
                Operator = Operator.Get(datas[1].ToCharArray()[0]),
                Op = datas[1],
                SecondVariable = secVar,
                Value = val
            };
            // new Variable
            //{
            //    Name = datas[0].Trim(),
            //    Value = int.Parse(datas[1].Trim())
            //};
        }


        #region Private Methods
        public AssignmentOperation ParseAssignment(string data)
        {
            var content = data.Split('=');
            return new AssignmentOperation { Identifier = content[0].Trim(), Expression = ParseExpression(content[1]) };
        }
        public ExpressionOperation ParseExpression(string data)
        {
            return null;
        }
        #endregion
        #region Static Methods
        private static bool IsAssignment(string data)
        {
            return true;
        }
        private static bool IsIdentifier(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z0-9_]+$");
        }
        private static bool IsDigit(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]+$");
        }
        #endregion
    }
}
