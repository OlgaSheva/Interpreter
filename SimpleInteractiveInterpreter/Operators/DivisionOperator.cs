namespace SimpleInteractiveInterpreter.Operators
{
    public class DivisionOperator : Operator
    {
        #region Constants
        public const string OPERATOR_STRING = "/";
        #endregion
        #region Constructors
        public DivisionOperator() : base(OPERATOR_STRING) { }
        #endregion
        public override int Execute(int a, int b)
        {
            return a / b;
        }
    }
}
