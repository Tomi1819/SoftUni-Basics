using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal seaPrice = 680;
            const decimal mountainPrice = 499;

            int seaCount = int.Parse(Console.ReadLine());
            int moutainCount = int.Parse(Console.ReadLine());

            decimal profit = 0;
            string inputLine = "";

            while (true)
            {
                inputLine = Console.ReadLine();
                if (inputLine == "Stop")
                {
                    break;
                }
                if (inputLine == "sea" && seaCount != 0)
                {
                    profit += seaPrice;
                    seaCount--;
                }
                else if (inputLine == "mountain" && moutainCount != 0)
                {
                    profit += mountainPrice;
                    moutainCount--;
                }

                if (seaCount == 0)
                    if (moutainCount == 0)

                        break;

                if (moutainCount == 0)
                    if (seaCount == 0)

                        break;
            }
            if (inputLine != "Stop")
            {
                Console.WriteLine("Good job! Everything is sold.");
                Console.WriteLine($"Profit: {profit} leva.");
            }
            else
            {
                Console.WriteLine($"Profit: {profit} leva.");
            }
        }
    }
}
