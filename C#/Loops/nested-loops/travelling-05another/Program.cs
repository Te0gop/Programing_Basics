﻿using System;

namespace travelling_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudgetNeeded = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                for (double i = minBudgetNeeded; i > savedMoney;)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}