using System;
using System.Collections.Generic;
using System.Text;
using SimpleInteractiveInterpreter.Operators;

namespace SimpleInteractiveInterpreter
{
    public class Result
    {
        public Variable Variable { get; set; }
        public Variable SecondVariable { get; set; }
        public IOperator Operator { get; set; }
        public string Op { get; set; }
        public int Value { get; set; }
    }
}
