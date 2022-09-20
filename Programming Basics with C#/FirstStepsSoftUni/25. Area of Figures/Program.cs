using System;

namespace _25._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;
            if (type == "square")
            {
                double num = double.Parse(Console.ReadLine());
                area = num * num;
            }
            else if (type == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                area = num1 * num2;
            }
            else if (type == "circle")
            {
                double num = double.Parse(Console.ReadLine());
                area = Math.PI * num * num;
            }
            else if (type == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                area = (num1 * num2) / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
