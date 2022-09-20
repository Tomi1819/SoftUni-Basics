using System;

namespace _01._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawPriceKg = double.Parse(Console.ReadLine());
            double bananaQuantity = double.Parse(Console.ReadLine());
            double orangesQuantity = double.Parse(Console.ReadLine());
            double rasbberiesQuantity = double.Parse(Console.ReadLine());
            double strawQuantity = double.Parse(Console.ReadLine());

            double rasbberiesPriceKg = strawPriceKg * 0.50;
            double orangesPriceKg = rasbberiesPriceKg * 0.60;
            double bananaPriceKg = rasbberiesPriceKg * 0.20;

            double sum = (strawQuantity * strawPriceKg) +
                           (bananaQuantity * bananaPriceKg) +
                           (orangesQuantity * orangesPriceKg) +
                           (rasbberiesQuantity * rasbberiesPriceKg);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
