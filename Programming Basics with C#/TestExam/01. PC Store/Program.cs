﻿using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var processorUsd = double.Parse(Console.ReadLine());
            var processorBgn = processorUsd * 1.57;
            var videoUsd = double.Parse(Console.ReadLine());
            var videoBgn = videoUsd * 1.57;
            var ramUsd = double.Parse(Console.ReadLine());
            var ramBgn = ramUsd * 1.57;
            var ramQuantity = int.Parse(Console.ReadLine());
            var ramPrice = ramBgn * ramQuantity;
            var discount = double.Parse(Console.ReadLine());
            var processorTotal = processorBgn - (processorBgn * discount);
            var videoTotal = videoBgn - (videoBgn * discount);
            var ramTotal = ramPrice;
            var totalPrice = processorTotal + videoTotal + ramTotal;
            Console.WriteLine($"Money needed - {totalPrice:F2} leva.");
        }
    }
}
