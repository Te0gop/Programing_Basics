using System;

namespace tripExpenses_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int vacationDuration = int.Parse(Console.ReadLine());
            int dayLimit = 60;
            int productCounter = 0;
            

            for (int i = 0; i < vacationDuration; i++)
            {
                string product = Console.ReadLine();
                bool noMoney = false;

                while (product != "Day over")
                {
                    int productPrice = int.Parse(product);

                    if (productPrice > dayLimit)
                    {
                        product = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        dayLimit -= productPrice;
                        productCounter++;
                    }
                    if (dayLimit == 0)
                    {
                        Console.WriteLine($"Daily limit exceeded! You've bought {productCounter} products.");
                        noMoney = true;
                        break;
                    }
                    product = Console.ReadLine();

                }
                if (!noMoney)
                {
                    Console.WriteLine($"Money left from today: {dayLimit:f2}. You've bought {productCounter} products.");
                    dayLimit += 60;
                }
                else
                {
                    dayLimit = 60;
                }
                productCounter = 0;
            }
        }
    }
}
