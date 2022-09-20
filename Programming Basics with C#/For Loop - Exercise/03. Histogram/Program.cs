using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0; //pod 200
            double p2 = 0; // 200-399
            double p3 = 0; // 400-599
            double p4 = 0; // 600-799
            double p5 = 0; //nad 800

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num <=199)
                {
                    p1++;
                }
                else if (num >=200 && num <=399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else if (num >=800)
                {
                    p5++;
                }
            }
            double percentP1 = (p1 / n) * 100;
            double percentP2 = (p2 / n) * 100;
            double percentP3 = (p3 / n) * 100;
            double percentP4 = (p4 / n) * 100;
            double percentP5 = (p5 / n) * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
            Console.WriteLine($"{percentP4:f2}%");
            Console.WriteLine($"{percentP5:f2}%");
        }
    }
}
