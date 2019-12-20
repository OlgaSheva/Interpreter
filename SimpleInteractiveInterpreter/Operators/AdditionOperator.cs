namespace SimpleInteractiveInterpreter.Operators
{
    public class AdditionOperator : Operator
    {
        #region Constants
        public const string OPERATOR_STRING = "+";
        #endregion
        #region Constructors
        public AdditionOperator() : base(OPERATOR_STRING) { }
        #endregion
        public override int Execute(int a, int b)
        {
            return a + b;
        }
    }
}
