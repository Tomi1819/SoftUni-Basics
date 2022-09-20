using System;

namespace _18._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())/100;

            double volume = lenth * width * height;
            double volumeInLiters = volume / 1000;
            double liters = volumeInLiters * (1 - percent);
            Console.WriteLine(liters);
        }
    }
}
