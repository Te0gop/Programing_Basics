using System;

namespace christmasMarket_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string christmasToys = Console.ReadLine();
            int toysCounter = 0;
            double moneySpent = 0;
            bool noMoney = false;

            while (christmasToys != "Finish")
            {
                toysCounter++;
                double currentPrice = 0;

                switch (christmasToys)
                {
                    case "Star":
                        currentPrice = 5.69;
                        break;
                    case "Angel":
                        currentPrice = 8.49;
                        break;
                    case "Lights":
                        currentPrice = 11.20;
                        break;
                    case "Wreath":
                        currentPrice = 15.50;
                        break;
                    case "Candle":
                        currentPrice = 3.59;
                        break;
                }
                if (toysCounter % 3 == 0)
                {
                    currentPrice *= 0.70;
                }

                moneySpent += currentPrice;

                if (budget <= moneySpent)
                {
                    toysCounter--;
                    Console.WriteLine($"Not enough money! You need {moneySpent-budget:F2}lv more.");
                    Console.WriteLine($"{toysCounter} items -> {moneySpent-currentPrice:F2}lv spent.");
                    noMoney = true;
                    break;
                }

                christmasToys = Console.ReadLine();
            }
            if (!noMoney)
            {
                Console.WriteLine("Congratulations! You bought everything!");
                Console.WriteLine($"{toysCounter} items -> {moneySpent:F2}lv spent.");
            }
        }
    }
}
