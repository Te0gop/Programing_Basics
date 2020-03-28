using System;

namespace easterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            int counter = 0;
            double currentPrice = 0;

            for (int i = 0; i < clients; i++)
            {
                string items = Console.ReadLine();

                while (items != "Finish")
                {
                    counter++;
                    switch (items)
                    {
                        case "basket":
                            currentPrice += 1.50;
                            break;
                        case "wreath":
                            currentPrice += 3.80;
                            break;
                        case "chocolate bunny":
                            currentPrice += 7;
                            break;
                    }

                    items = Console.ReadLine();
                }

                if (counter % 2 == 0)
                {
                    currentPrice -= currentPrice * 0.20;
                }

                Console.WriteLine($"You purchased {counter} items for {currentPrice:f2} leva.");
                totalPrice += currentPrice;
                currentPrice = 0;
                counter = 0;

            }
            Console.WriteLine($"Average bill per client is: {totalPrice / clients:f2} leva.");
        }
    }
}
