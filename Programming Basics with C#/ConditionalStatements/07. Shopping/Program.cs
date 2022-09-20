using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            int gpuPrice = gpu * 250;
            double cpuPrice = cpu * gpuPrice * 0.35;
            double ramPrice = ram * gpuPrice * 0.10;

            double totalAmount = gpuPrice + cpuPrice + ramPrice;

            if (gpu > cpu)
            {
                totalAmount *= 0.85;
            }
            if (budget >= totalAmount)
            {
                Console.WriteLine($"You have {(budget - totalAmount):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalAmount - budget):f2} leva more!");
            }
        }
    }
}