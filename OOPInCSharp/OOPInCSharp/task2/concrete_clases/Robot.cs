using System;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.enums;
using OOPInCSharp.task2.interfaces;

/**
* Created by Oleksandr_Breslavets on 11/25/2016.
*/
namespace OOPInCSharp.task2.concrete_clases
{
    public class Robot : AbstractToy, IDressable, IShootable
    {
        private const int MaxCost = 5000;

        private const int MinCost = 1000;

        public Robot(Volume size) : base(size)
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
