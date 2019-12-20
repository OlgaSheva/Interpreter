namespace SimpleInteractiveInterpreter.Operators
{
    public class RemainderOperator : Operator
    {
        #region Constants
        public const string OPERATOR_STRING = "%";
        #endregion
        #region Constructors
        public RemainderOperator() : base(OPERATOR_STRING) { }
        #endregion
        public override int Execute(int a, int b)
        {
            return a % b;
        }
    }
}
