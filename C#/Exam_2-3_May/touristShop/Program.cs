using System;

namespace touristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string productName = Console.ReadLine();
            int counter = 0;
            double productsSum = 0;
            bool leftMoney = false;

            while (productName != "Stop")
            {
                counter++;
                double productPrice = double.Parse(Console.ReadLine());

                if (counter % 3 == 0)
                {
                    productPrice *= 0.50;
                }
                if (productPrice > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {productPrice - budget:f2} leva!");
                    leftMoney = true;
                    break;
                }

                productsSum += productPrice;
                budget -= productPrice;
                productName = Console.ReadLine();
            }
            if (!leftMoney)
            {
                Console.WriteLine($"You bought {counter} products for {productsSum:f2} leva.");
            }

        }
    }
}
