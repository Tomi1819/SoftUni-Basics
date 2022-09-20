using System;

namespace _16._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChickenMenu = int.Parse(Console.ReadLine());
            int numberOfFishMenu = int.Parse(Console.ReadLine());
            int numberOfVegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegetarianMenu = 8.15;
            double priceForOrder = 2.50;

            double order = (numberOfChickenMenu * chickenMenu) + (numberOfFishMenu * fishMenu) + (numberOfVegetarianMenu * vegetarianMenu);

            double dessert = order * 0.20;

            double total = (order + dessert) + priceForOrder;
            Console.WriteLine(total);
        }
    }
}
