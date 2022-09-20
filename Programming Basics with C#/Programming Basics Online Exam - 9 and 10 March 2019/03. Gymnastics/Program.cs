using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double hard = 0;
            double performance = 0;

            if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    hard = 9.600;
                    performance = 9.400;
                }
                else if (device == "hoop")
                {
                    hard = 9.550;
                    performance = 9.750;
                }
                else if (device == "rope")
                {
                    hard = 9.500;
                    performance = 9.400;
                }
            }
            else if (country == "Russia")
            {
                if (device == "ribbon")
                {
                    hard = 9.100;
                    performance = 9.400;
                }
                else if (device == "hoop")
                {
                    hard = 9.300;
                    performance = 9.800;
                }
                else if (device == "rope")
                {
                    hard = 9.600;
                    performance = 9.000;
                }
            }
            else if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    hard = 9.200;
                    performance = 9.500;
                }
                else if (device == "hoop")
                {
                    hard = 9.450;
                    performance = 9.350;
                }
                else if (device == "rope")
                {
                    hard = 9.700;
                    performance = 9.150;
                }
            }
            double grade = hard + performance;
            double difference = 20- grade;
            Console.WriteLine($"The team of {country} get {grade:f3} on {device}.");
            Console.WriteLine($"{(difference/20)*100:f2}%");
        }
    }
}
