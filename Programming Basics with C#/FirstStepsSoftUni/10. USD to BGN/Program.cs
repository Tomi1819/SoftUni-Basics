using System;

namespace _10._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double bgn = double.Parse(Console.ReadLine());
            double usd = 1.79549;
            Console.WriteLine(bgn*usd);
        }
    }
}
