using System;

namespace _19._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            bool excellent = grade >= 5.50;
            if (excellent)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
