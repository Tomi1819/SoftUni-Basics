using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            double startedPoints = double.Parse(Console.ReadLine());
            double sumW = 0;
            double sumF = 0;
            double sumSf = 0;
            double counterW = 0;
            for (int i = 0; i <= tournaments; i++)
            {
                string lvl = Console.ReadLine();
                if (lvl == "W")
                {
                    sumW += 2000;
                    counterW++;
                }
                else if (lvl == "F")
                {
                    sumF += 1200;
                }
                else if (lvl == "SF")
                {
                    sumSf += 720;
                }
            }
            double allPoints = startedPoints + (sumW + sumF + sumSf);
            double sumForTour = sumW + sumF + sumSf;
            double average = Math.Floor(sumForTour / tournaments);
            double winTourPercentage = (counterW / tournaments) * 100;

            Console.WriteLine($"Final points: {allPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{winTourPercentage:f2}%");
        }
    }
}
