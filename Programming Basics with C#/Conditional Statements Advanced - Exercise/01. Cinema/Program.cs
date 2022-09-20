using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double price = 0;
            double sum = 0;

            switch (type)
            {
                case "Premiere":
                    price = 12;
                    sum = rows * cols * price;
                    break;
                case "Normal":
                    price = 7.50;
                    sum = rows * cols * price;
                    break;
                case "Discount":
                    price = 5.00;
                    sum = rows * cols * price;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
