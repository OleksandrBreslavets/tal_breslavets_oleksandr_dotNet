
namespace OOPInCSharp.task1.operations.@base
{
    public abstract class Operation
    {
        /// <summary>
        /// An abstract method that provides an opportunity
        /// to make more specific action
        /// </summary>
        /// <param name="a">first operand</param>
        /// <param name="b">second operand</param>
        /// <returns>a result of action</returns>
        public abstract int doAction(int a, int b);
    }
}
