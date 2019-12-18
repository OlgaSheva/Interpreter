namespace SimpleInteractiveInterpreter.Operators
{
    public class AdditionOperator : Operator
    {
        public override int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
