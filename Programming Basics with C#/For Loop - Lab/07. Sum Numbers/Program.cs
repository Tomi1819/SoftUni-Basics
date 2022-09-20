using System;

namespace _07._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfInputs = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            for (int i = 0; i < countOfInputs; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfNumbers += currentNumber;
                //sumOfNumbers = sumOfNumbers + currentNumber;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
