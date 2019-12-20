namespace SimpleInteractiveInterpreter.Operators
{
    public class SubtractionOperator : Operator
    {
        #region Constants
        public const string OPERATOR_STRING = "-";
        #endregion
        #region Constructors
        public SubtractionOperator() : base(OPERATOR_STRING) { }
        #endregion
        public override int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
