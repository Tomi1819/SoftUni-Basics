using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            double serialTime = double.Parse(Console.ReadLine());
            double lunchTime = double.Parse(Console.ReadLine());

            
            double neededTime = lunchTime * 5 / 8.0;

            if (neededTime >= serialTime)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(neededTime - serialTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(neededTime - serialTime)} more minutes.");
            }
        }
    }
}
