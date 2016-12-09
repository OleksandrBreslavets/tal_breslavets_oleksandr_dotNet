using System;
using System.Threading;
using OOPInCSharp.task2.abstract_clases;
using OOPInCSharp.task2.concrete_clases;
using OOPInCSharp.task2.enums;

/**
* Created by Sarkel on 26.11.2016.
* A container for toys
*/
namespace OOPInCSharp.task2.container
{
    public class GameRoom
    {
        private AbstractToy[] toys;
        
        /// <summary>
        /// Maximum amount of money that customer can spend
        /// </summary>
        private int maxCheque = 0;

        /// <summary>
        /// The amount of toys that customer wants
        /// </summary>
        private int amount = 0;

        public GameRoom(int maxCheque, int amount)
        {
            toys = new AbstractToy[amount];
            this.maxCheque = maxCheque;
            this.amount = amount;
            GenerateToys(maxCheque, amount);
        }


        /// <summary>
        /// Method generate an array of toys according to the customers needs
        /// and resources
        /// </summary>
        /// <param name="maxCheque">Maximum amount of money that customer can spend</param>
        /// <param name="amount">The amount of toys that customer wants</param>
        private void GenerateToys(int maxCheque, int amount)
        {
            int currentCheque = 0;
            int attempts = 0;
            const int maxAttemptCount = 100;

            for (int i = 0; i < amount; i++)
            {
                int toyTypeIndex = new Random().Next(Enum.GetValues(typeof(ToysType)).Length - 1);
                ToysType toyType = (ToysType)toyTypeIndex;

                Thread.Sleep(50);
                int toyVolumeIndex = new Random().Next(Enum.GetValues(typeof(Volume)).Length - 1);
                Volume toyVolume = (Volume)toyVolumeIndex;

                toys[i] = CreateToy(toyType, toyVolume);
                currentCheque += toys[i].Price;

                if (attempts == maxAttemptCount)
                {
                    Console.WriteLine("Please reconsider your order options, " +
                                      "it's too difficult to meet you needs");
                    toys = null;
                    return;
                }
                if (maxCheque < currentCheque)
                {
                    i = -1;
                    currentCheque = 0;
                    attempts++;
                }
            }
        }


        /// <summary>
        /// Gererate an instance of a particular class
        /// </summary>
        /// <param name="type">type of class</param>
        /// <param name="volume">Volume parameter</param>
        /// <returns>an instance of class upcasted to AbstractToy</returns>
        private AbstractToy CreateToy(ToysType type, Volume volume)
        {
            AbstractToy toy = null;
            switch (type)
            {
                case ToysType.Car:
                    toy = new Car(volume);
                    break;
                case ToysType.Construction:
                    toy = new Car(volume);
                    break;
                case ToysType.Doll:
                    toy = new Doll(volume);
                    break;
                case ToysType.Pistol:
                    toy = new Pistol(volume);
                    break;
                case ToysType.Puzzle:
                    toy = new Puzzle(volume);
                    break;
                case ToysType.Robot:
                    toy = new Robot(volume);
                    break;
            }
            return toy;
        }


        /// <summary>
        /// sort array ascending by price
        /// </summary>
        public void Sort()
        {
            for (int i = toys.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (toys[j].Price > toys[j + 1].Price)
                    {
                        AbstractToy tmp = toys[j];
                        toys[j] = toys[j + 1];
                        toys[j + 1] = tmp;
                    }
                }
            }
        }


        /// <summary>
        /// Output in a console whole toy array
        /// </summary>
        public void Show()
        {
            if (toys != null)
            {
                int totalPrice = 0;
                foreach (AbstractToy toy in toys)
                {
                    totalPrice += toy.Price;
                    Console.WriteLine($"{toy.GetType().Name} \t {toy.Price} \t {toy.Size}");
                }
                Console.WriteLine($"Your order: max total price is {maxCheque} and amount of toys is {amount}");
                Console.WriteLine($"The total price of game room is {totalPrice}");
            }
            else
            {
                Console.WriteLine("There are no toys in room");
            }
        }


        /// <summary>
        /// Output all toys that meet volume parameters
        /// </summary>
        /// <param name="volume">parameter for filtering</param>
        public void Filter(params Volume[] volume)
        {
            int counter = 0;
            foreach (Volume vol in volume)
            {
                foreach (AbstractToy toy in toys)
                {
                    if (toy.Size == vol)
                    {
                        Console.WriteLine($"{toy.GetType().Name} \t {toy.Price} \t {toy.Size}");
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("There are no items with such option");
            }
        }
    }
}
