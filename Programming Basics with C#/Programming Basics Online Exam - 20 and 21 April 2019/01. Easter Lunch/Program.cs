using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double bread = 3.20;
            double eggs = 4.35;
            double cookies = 5.40;
            double paint = 0.15;

            int numberOfBread = int.Parse(Console.ReadLine());
            int numberOfEggs = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());

            double allWithoutPaint = (numberOfBread * bread) +
                                      (numberOfEggs * eggs) +
                                      (kgCookies * cookies);
            double sum = (numberOfEggs * 12 * paint) + allWithoutPaint;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
