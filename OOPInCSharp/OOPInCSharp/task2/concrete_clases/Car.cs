using System;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.enums;
using OOPInCSharp.task2.interfaces;

/**
* Created by Oleksandr_Breslavets on 11/25/2016.
* Class represents a toy car object
*/
namespace OOPInCSharp.task2.concrete_clases
{
    public class Car : AbstractToy, IVehicle
    {
        private const int MaxCost = 500;

        private const int MinCost = 100;

        public Car(Volume size) : base(size)
        {
            base.SetPrice(MaxCost, MinCost);
        }

        public void Move()
        {
            Console.WriteLine("Move a car");
        }

        public override void Play()
        {
            Console.WriteLine("Play with a car");
        }
    }
}
