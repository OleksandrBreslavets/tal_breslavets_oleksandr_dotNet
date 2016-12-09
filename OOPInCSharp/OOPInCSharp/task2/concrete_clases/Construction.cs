using System;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.enums;
using OOPInCSharp.task2.interfaces;

/**
* Created by Oleksandr_Breslavets on 11/25/2016.
* Class represents a toy construction object, like LEGO
*/
namespace OOPInCSharp.task2.concrete_clases
{
    public class Construction : AbstractToy, ICollectible
    {
        private const int MaxCost = 2000;

        private const int MinCost = 300;

        public Construction(Volume size) : base(size)
        {
            base.SetPrice(MaxCost, MinCost);
        }

        public void Collect()
        {
            Console.WriteLine("Collect a construction!");
        }

        public void Recollect()
        {
            Console.WriteLine("Recollect a construction(");
        }

        public override void Play()
        {
            Console.WriteLine("Play with a construction");
        }
    }
}
