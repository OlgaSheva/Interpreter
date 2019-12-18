namespace SimpleInteractiveInterpreter.Operators
{
    public class RemainderOperator : Operator
    {
        public override int Execute(int a, int b)
        {
            return a % b;
        }
    }
}
