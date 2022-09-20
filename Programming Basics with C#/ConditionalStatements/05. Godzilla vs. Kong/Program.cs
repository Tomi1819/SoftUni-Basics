using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double extra = double.Parse(Console.ReadLine());
            double priceForOneOutfit = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalOutFit = extra * priceForOneOutfit;

            if (extra > 150)
            {
                totalOutFit = totalOutFit - (totalOutFit * 0.10);
            }
            double neededMoney = decor + totalOutFit;
            double difference = budget - neededMoney;
            if (neededMoney > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
        }
    }
}
