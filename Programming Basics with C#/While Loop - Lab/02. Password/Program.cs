using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pwd = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != pwd)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
