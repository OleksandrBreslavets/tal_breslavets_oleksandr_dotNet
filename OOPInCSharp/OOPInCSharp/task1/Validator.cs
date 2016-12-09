using System.Text.RegularExpressions;

/**
* Created by Oleksandr_Breslavets on 11/22/2016.
* Provide a methods for checking numbers and operations for Calculator
*/
namespace OOPInCSharp.task1
{
    class Validator
    {
        /// <summary>
        /// Check string contains a number
        /// </summary>
        /// <param name="str">string that will be checked</param>
        /// <returns> whether string is a number - true, or not a number - false</returns>
        public static bool IsNumber(string str)
        {
            string pattern = "\\d+";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }

        /// <summary>
        /// Check string contains an operator
        /// </summary>
        /// <param name="str"> string that will be checked</param>
        /// <returns> whether string is a operator - true, or not a operator - false</returns>
        public static bool IsOperator(string str)
        {
            string pattern = "[*+/-]";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
    }
}
