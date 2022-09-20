using System;

namespace _14._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPackagesOfPens = int.Parse(Console.ReadLine());
            int numberOfPackagesOfMarkers = int.Parse(Console.ReadLine());
            int numberOfCleeningDetergent = int.Parse(Console.ReadLine());
            int percentigeReduction = int.Parse(Console.ReadLine());

            double pens = 5.80;
            double markers = 7.20;
            double detergent = 1.20;

            double priceForPens = numberOfPackagesOfPens * pens;
            double priceForMarkers = numberOfPackagesOfMarkers * markers;
            double priceForDetergent = numberOfCleeningDetergent * detergent;

            double priceForAll = priceForPens + priceForMarkers + priceForDetergent;
            double priceWithReduction = priceForAll - ((priceForAll * percentigeReduction)/100);
            Console.WriteLine(priceWithReduction);
            
        }
    }
}
