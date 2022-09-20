using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numOne; i+=2)
            {
                for (int b = 2; b <= numTwo; b++)
                {
                    for (int c = 2; c <= numThree; c+=2)
                    {
                        if (b == 2 || b==3 || b==5 || b==7)
                        {
                            Console.WriteLine($"{i} {b} {c}");
                        }
                    }
                }
            }
        }
    }
}
