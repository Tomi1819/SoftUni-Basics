﻿using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int breads = int.Parse(Console.ReadLine());
            string bestBakerName = "";
            int bestBakerPoints = -1;
            for (int i = 0; i < breads; i++)
            {
                string bakerName = Console.ReadLine();
                int points = 0;
                string command = Console.ReadLine();
                while (command != "Stop")
                {
                    points += int.Parse(command);
                    command = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {points} points.");
                if (points > bestBakerPoints)
                {
                    bestBakerName = bakerName;
                    bestBakerPoints = points;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                }
            }
            Console.WriteLine($"{bestBakerName} won competition with {bestBakerPoints} points!");
        }
    }
}
