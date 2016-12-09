using System;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.enums;
using OOPInCSharp.task2.interfaces;

/**
* Created by Oleksandr_Breslavets on 11/25/2016.
* Class represents a toy doll object
*/
namespace OOPInCSharp.task2.concrete_clases
{
    public class Doll : AbstractToy, IDressable
    {
        private const int MaxCost = 1500;

        private const int MinCost = 50;

        public Doll(Volume size) : base(size)
        {
            base.SetPrice(MaxCost, MinCost);
        }

        public void PutOn()
        {
            Console.WriteLine("Put on dress on a doll");
        }

        public void TakeOff()
        {
            Console.WriteLine("Take off my dress with a doll");
        }

        public override void Play()
        {
            Console.WriteLine("Play with a doll");
        }
    }
}
