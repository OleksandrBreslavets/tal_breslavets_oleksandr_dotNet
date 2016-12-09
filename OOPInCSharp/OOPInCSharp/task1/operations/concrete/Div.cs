using System;
using OOPInCSharp.task1.operations.@base;

namespace OOPInCSharp.task1.operations.concrete
{
    public class Div : Operation
    {
        public override int doAction(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            throw new DivideByZeroException("Your are trying to dived by zero");
        }

    }
}
