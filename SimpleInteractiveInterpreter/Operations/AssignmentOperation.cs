namespace SimpleInteractiveInterpreter.Operations
{
    public class AssignmentOperation : Operation
    {
        public string Identifier { get; set; }
        public ExpressionOperation Expression { get; set; }
    }
}
