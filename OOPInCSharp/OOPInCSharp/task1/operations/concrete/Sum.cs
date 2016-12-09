using OOPInCSharp.task1.operations.@base;

namespace OOPInCSharp.task1.operations.concrete
{
    public class Sum : Operation
    {
        public override int doAction(int a, int b)
        {
            return a + b;
        }
    }
}
