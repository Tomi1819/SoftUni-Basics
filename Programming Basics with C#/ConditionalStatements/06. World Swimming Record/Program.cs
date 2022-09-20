using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOne = double.Parse(Console.ReadLine());

            double swimTime = distance * timeForOne;
            double swimAfter = Math.Floor((distance / 15)) * 12.5;
            double sumTime = swimTime + swimAfter;
            double difference = sumTime - record;

            if (sumTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {sumTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
        }
    }
}
