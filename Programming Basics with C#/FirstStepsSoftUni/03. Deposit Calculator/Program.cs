using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());
            double interest = depositAmount * yearPercent / 100 / 12;
            double sum = depositTerm * interest;
            double sum1 = depositAmount + sum;
            Console.WriteLine(sum1);
        }
    }
}
