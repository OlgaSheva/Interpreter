using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInteractiveInterpreter.Operators
{
    public class MultiplicationOperator : Operator
    {
        public override int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
