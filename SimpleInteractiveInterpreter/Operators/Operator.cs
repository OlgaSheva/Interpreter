﻿namespace SimpleInteractiveInterpreter.Operators
{
    public abstract class Operator : IOperator
    {
        private string OperatorString { get; set; }

        public Operator(string operatorString)
        {
            OperatorString = operatorString;
        }

        public static IOperator Get(char operatorChar)
        {
            return operatorChar switch
            {
                '+' => new AdditionOperator(),
                '-' => new SubtractionOperator(),
                '*' => new MultiplicationOperator(),
                '/' => new DivisionOperator(),
                '%' => new RemainderOperator(),
                _ => null
            };
        }
        public abstract int Execute(int a, int b);
        public string GetOperatorString()
        {
            return OperatorString;
        }
    }
}
