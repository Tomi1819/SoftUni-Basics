using System;

namespace _17._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());

            double shoes = taxPerYear - taxPerYear * 0.4;
            double outfit = shoes - shoes * 0.2;
            double ball = outfit / 4;
            double accsesories = ball / 5;
            double total = taxPerYear+ shoes + outfit + ball + accsesories;
            Console.WriteLine(total);

        }
    }
}
