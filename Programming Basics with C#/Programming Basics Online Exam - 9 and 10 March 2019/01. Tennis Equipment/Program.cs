using System;

namespace _01._Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForOneRocket = double.Parse(Console.ReadLine());
            double numberOfRockets = double.Parse(Console.ReadLine());
            double numberOfSneakers = double.Parse(Console.ReadLine());

            double priceForPearSneakers = priceForOneRocket * 1 / 6;
            double priceForRockets = numberOfRockets * priceForOneRocket;
            double priceForSneakers = numberOfSneakers * priceForPearSneakers;
            double otherEquipment = (priceForSneakers + priceForRockets) * 0.2;
            double sum = priceForSneakers + priceForRockets + otherEquipment;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor( sum*1/8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(sum * 7/8)}");
        }
    }
}
