using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPInCSharp.task1;
using OOPInCSharp.task2.container;
using OOPInCSharp.task2.enums;

namespace OOPInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.InputNumbers();

            Console.WriteLine();

            int cheque = 10000;
            int amount = 12;

            GameRoom gameRoom = new GameRoom(cheque, amount);
            gameRoom.Show();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Now sort the GameRoom by the toy's price");
            Console.ResetColor();
            gameRoom.Sort();
            gameRoom.Show();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Now we filter the GameRoom by the BIG volume ");
            Console.ResetColor();
            gameRoom.Filter(Volume.Big, Volume.Small);
        }
    }
}
