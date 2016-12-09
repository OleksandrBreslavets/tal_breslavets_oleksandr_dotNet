using OOPInCSharp.task1.operations.@base;

/**
 * Created by Oleksandr_Breslavets on 11/25/2016.
 */
namespace OOPInCSharp.task1.operations.concrete
{
    public class Sub : Operation
    {
        public override int doAction(int a, int b)
        {
            return a - b;
        }
    }
}
