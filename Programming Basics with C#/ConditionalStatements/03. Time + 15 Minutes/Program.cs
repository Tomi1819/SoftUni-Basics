using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mintutes = int.Parse(Console.ReadLine());

            mintutes = mintutes + (hours * 60);
            int minutesAfter15 = mintutes + 15;

            int hAfter = minutesAfter15 / 60;
            int mAfter = minutesAfter15 % 60;

            if (hAfter > 23)
            {
                hAfter = 0;
            }
            if (mAfter < 10)
            {
                Console.WriteLine($"{hAfter}:0{mAfter}");
            }
            else
            {
                Console.WriteLine($"{hAfter}:{mAfter}");
            }
        }
    }
}
