using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForTour = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double puzzle = 2.60;
            double doll = 3;
            double bear = 4.10;
            double minion = 8.20;
            double truck = 2;

            int allToys = numberOfPuzzles +
                      numberOfPuzzles +
                      numberOfDolls +
                      numberOfBears +
                      numberOfMinions +
                      numberOfTrucks;

            double totalPrice = numberOfPuzzles * puzzle +
                                numberOfDolls * doll +
                                numberOfBears * bear +
                                numberOfMinions * minion +
                                numberOfTrucks * truck;

            if (allToys >=50)
            {
                totalPrice *= 0.75;
            }

            totalPrice *= 0.90;
            double difference = totalPrice - priceForTour;

            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):f2} lv needed.");
            }
        }
    }
}
