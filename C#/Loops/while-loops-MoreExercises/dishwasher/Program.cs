using System;

namespace dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int detergentBottle = int.Parse(Console.ReadLine());

            double ml = detergentBottle * 750;
            int dishes = 0;
            int pots = 0;
            int counter = 0;
            bool noDetergent = false;

            string bottles = Console.ReadLine();

            while (bottles != "End")
            {
                int quantity = int.Parse(bottles);
                counter++;

                if (ml >= 0)
                {
                    if (counter % 3 == 0)
                    {
                        ml -= quantity * 15;
                        pots += quantity;
                    }
                    else
                    {
                        ml -= quantity * 5;
                        dishes += quantity;
                    }

                }
                if (ml < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(ml)} ml. more necessary!");
                    noDetergent = true;
                    break;
                }

                bottles = Console.ReadLine();
            }

            if (!noDetergent)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {ml} ml.");
            }

        }
    }
}
