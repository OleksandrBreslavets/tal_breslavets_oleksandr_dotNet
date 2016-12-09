using System;
using OOPInCSharp.task1.operations.@base;
using OOPInCSharp.task1.operations.concrete;


namespace OOPInCSharp.task1
{
    public class Calculator
    {
        /// <summary>
        /// Method provides opportunity to input numbers in calculator and
        /// than do some operation with them
        /// </summary>
        public static void InputNumbers()
        {

            Show("Please input a");
            string inputA = Console.ReadLine();
            string a = Validator.IsNumber(inputA) ? inputA : null;

            Show("Please input operation");
            string inputOperation = Console.ReadLine();
            string operation = Validator.IsOperator(inputOperation) ? inputOperation : null;

            Show("Please input b");
            string inputB = Console.ReadLine();
            string b = Validator.IsNumber(inputB) ? inputB : null;

            if (a != null & b != null & operation != null)
            {
                Operation operationToDo = null;
                switch (operation)
                {
                    case "+":
                        operationToDo = new Sum();
                        break;
                    case "-":
                        operationToDo = new Sub();
                        break;
                    case "*":
                        operationToDo = new Mul();
                        break;
                    case "/":
                        operationToDo = new Div();
                        break;
                }
                Show(operationToDo.doAction(Int32.Parse(a), Int32.Parse(b)));
            }
            else
            {
                Show("Mistake");
            }
        }


        /// <summary>
        /// Write in console what got
        /// </summary>
        /// <param name="o">An object that will be outputted</param>
        private static void Show(Object o)
        {
            Console.WriteLine(o);
        }
    }
}
