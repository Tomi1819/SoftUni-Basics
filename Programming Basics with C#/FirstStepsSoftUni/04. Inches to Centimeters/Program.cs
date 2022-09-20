using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double inches = 2.54;
            Console.WriteLine(num * inches);
        }
    }
}
