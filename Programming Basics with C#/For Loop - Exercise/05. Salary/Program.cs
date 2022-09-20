using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openTabs; i++)
            {
                string tab = Console.ReadLine();
                if (tab == "Facebook")
                {
                    salary -= 150;
                }
                else if (tab == "Instagram")
                {
                    salary -= 100;
                }
                else if (tab == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
        }
    }
}
