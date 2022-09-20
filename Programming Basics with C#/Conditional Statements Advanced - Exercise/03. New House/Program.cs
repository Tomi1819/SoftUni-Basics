using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;

            double total = 0;

            switch (flower)
            {
                case "Roses": total = numberOfFlowers * roses;
                    if (numberOfFlowers > 80)
                    {
                        total *= 0.9;
                    }
                    break;
                case "Dahlias":
                    total = numberOfFlowers * dahlias;
                    if (numberOfFlowers > 90)
                    {
                        total *= 0.85;
                    }
                    break;
                case "Tulips":
                    total = numberOfFlowers * tulips;
                    if (numberOfFlowers > 80)
                    {
                        total *= 0.85;
                    }
                    break;
                case "Narcissus":
                    total = numberOfFlowers * narcissus;
                    if (numberOfFlowers < 120)
                    {
                        total *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    total = numberOfFlowers * gladiolus;
                    if (numberOfFlowers < 80)
                    {
                        total *= 1.20;
                    }
                    break;
                default:
                    break;
            }
            if (budjet>= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {budjet-total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total-budjet:f2} leva more.");
            }
        }
    }
}
