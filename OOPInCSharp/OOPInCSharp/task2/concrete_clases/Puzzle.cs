using System;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.enums;
using OOPInCSharp.task2.interfaces;

/**
* Created by Oleksandr_Breslavets on 11/25/2016.
* Class represents a toy puzzle object
*/
namespace OOPInCSharp.task2.concrete_clases
{
    public class Puzzle : AbstractToy, ICollectible
    {
        private const int MaxCost = 800;

        private const int MinCost = 200;

        public Puzzle(Volume size) : base(size)
        {

            base.SetPrice(MaxCost, MinCost);
        }

        public override void Play()
        {
            Console.WriteLine("Play with a puzzle");
        }

        public void Collect()
        {
            Console.WriteLine("Collect a puzzle!");
        }

        public void Recollect()
        {
            Console.WriteLine("Recollect a puzzle(");
        }
    }
}
