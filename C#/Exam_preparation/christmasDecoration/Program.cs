using System;

namespace christmasDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            string toyName = Console.ReadLine();
            bool hasBudget = false;

            while (toyName != "Stop")
            {

                int toyPrice = 0;

                for (int i = 0; i < toyName.Length; i++)
                {
                    toyPrice += toyName[i];
                }

                if (budget >= toyPrice)
                {
                    Console.WriteLine($"Item successfully purchased!");
                    budget -= toyPrice;
                }
                else
                {
                    Console.WriteLine($"Not enough money!");
                    hasBudget = true;
                    break;
                }

                toyName = Console.ReadLine();
            }

            if (!hasBudget)
            {
                Console.WriteLine($"Money left: {budget}");
            }

        }
    }
}
