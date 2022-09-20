using System;

namespace _15._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededNylon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededTinner = int.Parse(Console.ReadLine());
            int hoursOfWork = int.Parse(Console.ReadLine());

            double nylon = 1.50;
            double paint = 14.50;
            double tinner = 5.00;

            double priceForPaint = (neededPaint + (neededPaint * 0.10)) * paint;
            double priceForNylon = (neededNylon + 2) * nylon;
            double priceForTinner = neededTinner * tinner;

            double priceForAll = (priceForPaint + priceForNylon + priceForTinner) + 0.40;

            double priceForWorkers = ((priceForAll * 0.30)*hoursOfWork);
            double total = priceForAll + priceForWorkers;
            Console.WriteLine(total);

        }
    }
}
