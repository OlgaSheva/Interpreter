using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInteractiveInterpreter.Operators
{
    public interface IOperator
    {
        int Execute(int a, int b);
    }
}
