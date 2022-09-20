using System;

namespace _02._Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double priceForCover = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            if (guests>= 10 && guests<= 15)
            {
                priceForCover = priceForCover - priceForCover * 0.15;
            }
            else if (guests>= 15 && guests <=20)
            {
                priceForCover = priceForCover - priceForCover * 0.20;
            }
            else if (guests> 25)
            {
                priceForCover = priceForCover - priceForCover * 0.25;
            }
            double cake = budjet * 0.10;
            double all = guests * priceForCover + cake;
            if (budjet> all)
            {
                Console.WriteLine($"It is party time! {budjet-all:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {all-budjet:f2} leva needed.");
            }
        }
    }
}
