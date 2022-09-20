using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOneEggs = int.Parse(Console.ReadLine());
            int playerTwoEggs = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "one")
                {
                    playerTwoEggs--;
                }
                else if (input == "two")
                {
                    playerOneEggs--;
                }
                if (playerOneEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                }
                else if (playerTwoEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs}eggs left.");
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
                Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
            }
        }
    }
}
