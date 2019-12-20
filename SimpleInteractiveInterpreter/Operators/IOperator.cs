namespace SimpleInteractiveInterpreter.Operators
{
    public interface IOperator
    {
        #region Methods
        int Execute(int a, int b);
        string GetOperatorString();
        #endregion
    }
}
