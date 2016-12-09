using System;
using OOPInCSharp.task2.enums;

/**
* Created by Oleksandr_Breslavets on 11/25/2016.
* It is a base class for all toys
*/
namespace OOPInCSharp.task2.abstract_clases
{
    public abstract class AbstractToy
    {
        private int _price;
        private Volume _size;

        public AbstractToy(Volume volume)
        {
            Size = volume;
        }

        public int Price
        {
            get { return _price; }
            private set { _price = value; }
        }

        public Volume Size
        {
            get { return _size; }
            set { _size = value; }
        }


        /***
     * Sets the price within min and max limits
     * @param max - The top limit for range
     * @param min - The bottom limit for range
     */
        public void SetPrice(int max, int min)
        {
            Price = new Random().Next(min, max);
        }


        /***
     * to play with a toy
     */
        public abstract void Play();
    }
}
