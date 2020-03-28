using System;

namespace sushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiKind = Console.ReadLine();
            string sushiRestrourant = Console.ReadLine();
            int servings = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();

            bool isValid = false;
            double totalPrice = 0;

            if (sushiRestrourant == "Sushi Zone")
            {
                if (sushiKind == "sashimi")
                {
                    totalPrice += servings * 4.99;
                }
                else if (sushiKind == "maki")
                {
                    totalPrice += servings * 5.29;
                }
                else if (sushiKind == "uramaki")
                {
                    totalPrice += servings * 5.99;
                }
                else if (sushiKind == "temaki")
                {
                    totalPrice += servings * 4.29;
                }

            }
            else if (sushiRestrourant == "Sushi Time")
            {
                if (sushiKind == "sashimi")
                {
                    totalPrice += servings * 5.49;
                }
                else if (sushiKind == "maki")
                {
                    totalPrice += servings * 4.69;
                }
                else if (sushiKind == "uramaki")
                {
                    totalPrice += servings * 4.49;
                }
                else if (sushiKind == "temaki")
                {
                    totalPrice += servings * 5.19;
                }

            }
            else if (sushiRestrourant == "Sushi Bar")
            {
                if (sushiKind == "sashimi")
                {
                    totalPrice += servings * 5.25;
                }
                else if (sushiKind == "maki")
                {
                    totalPrice += servings * 5.55;
                }
                else if (sushiKind == "uramaki")
                {
                    totalPrice += servings * 6.25;
                }
                else if (sushiKind == "temaki")
                {
                    totalPrice += servings * 4.75;
                }

            }
            else if (sushiRestrourant == "Asian Pub")
            {
                if (sushiKind == "sashimi")
                {
                    totalPrice += servings * 4.50;
                }
                else if (sushiKind == "maki")
                {
                    totalPrice += servings * 4.80;
                }
                else if (sushiKind == "uramaki")
                {
                    totalPrice += servings * 5.50;
                }
                else if (sushiKind == "temaki")
                {
                    totalPrice += servings * 5.50;
                }

            }
            else
            {
                Console.WriteLine($"{sushiRestrourant} is invalid restaurant!");
                isValid = true;
            }

            if (order == "Y")
            {
                totalPrice *= 1.2;
            }

            if (!isValid)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }

        }
    }
}
