using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string date = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double priceForNight = 0;
            if (destination == "France")
            {
                if (date == "21-23")
                {
                    priceForNight = 30;
                }
                else if (date == "24-27")
                {
                    priceForNight = 35;
                }
                else if (date == "28-31")
                {
                    priceForNight = 40;
                }
            }
            if (destination == "Italy")
            {
                if (date == "21-23")
                {
                    priceForNight = 28;
                }
                else if (date == "24-27")
                {
                    priceForNight = 32;
                }
                else if (date == "28-31")
                {
                    priceForNight = 39;
                }
            }
            if (destination == "Germany")
            {
                if (date == "21-23")
                {
                    priceForNight = 32;
                }
                else if (date == "24-27")
                {
                    priceForNight = 37;
                }
                else if (date == "28-31")
                {
                    priceForNight = 43;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {numberOfNights*priceForNight:f2} leva.");
        }
    }
}
