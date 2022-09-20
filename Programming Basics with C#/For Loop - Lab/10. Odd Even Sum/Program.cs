using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int counOfInputs = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= counOfInputs; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)}");
            }
        }
    }
}
