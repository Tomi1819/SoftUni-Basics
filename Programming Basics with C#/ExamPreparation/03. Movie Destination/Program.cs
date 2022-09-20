using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            double days = double.Parse(Console.ReadLine());
            double oneDay = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    oneDay = 45000;
                }
                else if (season== "Summer")
                {
                    oneDay = 40000;
                }
                oneDay *= 0.70;
            }
            if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    oneDay = 17000;
                }
                else if (season == "Summer")
                {
                    oneDay = 12500;
                }
                oneDay *= 1.25;
            }
            if (destination == "London")
            {
                if (season == "Winter")
                {
                    oneDay = 24000;
                }
                else if (season == "Summer")
                {
                    oneDay = 20250;
                }
            }
            double all = oneDay * days;
            if (budjet> all)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budjet-all:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {Math.Abs(all-budjet):f2} leva more!");
            }
        }
    }
}
