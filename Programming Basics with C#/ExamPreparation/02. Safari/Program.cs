using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            double budjet = double.Parse(Console.ReadLine());
            //· Брой нощувки – цяло число в интервала[0 … 1000]
            int nights = int.Parse(Console.ReadLine());
            //· Цена за нощувка – реално число в интервала[1.00 … 500.00]
            double priceForNight = double.Parse(Console.ReadLine());
            //· Процент за допълнителни разходи – цяло число в интервала[0 … 100
            double percentOthers = double.Parse(Console.ReadLine());

            if (nights > 7)
            {
                priceForNight *= 0.95;
            }
            double sum = priceForNight * nights;
            double percent = budjet * percentOthers / 100;
            double total = sum + percent;
            if (budjet>total)
            {
                Console.WriteLine($"Ivanovi will be left with {budjet-total:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{total-budjet:f2} leva needed.");
            }
        }
    }
}
