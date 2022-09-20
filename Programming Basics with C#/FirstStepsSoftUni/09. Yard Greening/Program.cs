using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());

            double oneKvm = 7.61;
            double finalPrice = kvm * oneKvm;
            double discount = 0.18 * finalPrice;
            double priceWithDiscount = finalPrice - discount;

            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The discont is: {discount}");
        }
    }
}
