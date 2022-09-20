using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodInKg = double.Parse(Console.ReadLine());
            double foodForFirstDeer = double.Parse(Console.ReadLine());
            double foodForSecondDeer = double.Parse(Console.ReadLine());
            double foodForThirdDeer = double.Parse(Console.ReadLine());

            double neededFoodForDay = foodForFirstDeer + foodForSecondDeer + foodForThirdDeer;
            double allNeededFood = days * neededFoodForDay;

            if (foodInKg >= allNeededFood)
            {
                Console.WriteLine($"{Math.Floor(foodInKg-allNeededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allNeededFood - foodInKg)} more kilos of food are needed.");
            }

        }
    }
}
