using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int packsForDogs = int.Parse(Console.ReadLine());
            int packsForCats = int.Parse(Console.ReadLine());

            double dogFood = 2.50;
            double catFood = 4.00;

            double totalPrice = (packsForDogs * dogFood) + (packsForCats * catFood);

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
