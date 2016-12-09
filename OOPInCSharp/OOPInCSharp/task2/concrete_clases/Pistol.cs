using System;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.enums;
using OOPInCSharp.task2.interfaces;

/**
* Created by Sarkel on 26.11.2016.
* Class represents a toy pistol object
*/
namespace OOPInCSharp.task2.concrete_clases
{
    public class Pistol : AbstractToy, IShootable
    {
        private const int MaxCost = 1200;

        private const int MinCost = 250;

        public Pistol(Volume size) : base(size)
        {
            base.SetPrice(MaxCost, MinCost);
        }

        public override void Play()
        {
            Console.WriteLine("Play with a doll");
        }

        public void Reload()
        {
            Console.WriteLine("Reload the robot gun");
        }

        public void Shoot()
        {
            Console.WriteLine("Robot make a shoot");
        }
    }
}
