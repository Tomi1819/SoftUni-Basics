using System;

namespace _03._Excursion_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double priceForPerson = 0;
            if (people <= 5)
            {
                if (season == "spring")
                {
                    priceForPerson = 50.00;
                }
                else if (season == "summer")
                {
                    priceForPerson = 48.50;
                    priceForPerson *= 0.85;
                }
                else if (season == "autumn")
                {
                    priceForPerson = 60.00;
                }
                else if (season == "winter")
                {
                    priceForPerson = 86.00;
                    priceForPerson *= 1.08;
                }
            }
            if (people > 5)
            {
                if (season == "spring")
                {
                    priceForPerson = 48.00;
                }
                else if (season == "summer")
                {
                    priceForPerson = 45.00;
                    priceForPerson *= 0.85;
                }
                else if (season == "autumn")
                {
                    priceForPerson = 49.50;
                }
                else if (season == "winter")
                {
                    priceForPerson = 85.00;
                    priceForPerson *= 1.08;
                }
            }
            Console.WriteLine($"{people*priceForPerson:f2} leva.");
        }
    }
}
