using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int trirdTime = int.Parse(Console.ReadLine());

            int totalSeconds = firstTime + secondTime + trirdTime;

            double min = totalSeconds / 60;
            double sec = totalSeconds % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
