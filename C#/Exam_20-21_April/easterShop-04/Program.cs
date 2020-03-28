using System;

namespace easterShop_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsQuantity = int.Parse(Console.ReadLine());

            bool noEggs = false;
            int soldEggs = 0;
            string buyOrFill = Console.ReadLine();

            while (buyOrFill != "Close")
            {
                int numberOfEggs = int.Parse(Console.ReadLine());

                if (buyOrFill == "Buy")
                {
                    if (eggsQuantity < numberOfEggs)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {eggsQuantity}.");
                        noEggs = true;
                        break;
                    }
                    soldEggs += numberOfEggs;
                    eggsQuantity -= numberOfEggs;

                }
                else if (buyOrFill == "Fill")
                {
                    eggsQuantity += numberOfEggs;
                }

                buyOrFill = Console.ReadLine();
            }
            if (!noEggs)
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }


        }
    }
}
