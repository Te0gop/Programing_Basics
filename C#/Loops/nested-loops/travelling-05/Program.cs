using System;

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
                bool endLoop = false;
                string savedMoney = string.Empty;

                while (!endLoop)
                {
                    savedMoney = Console.ReadLine();

                    if (savedMoney == "End")
                    {
                        break;
                    }

                    double savings = double.Parse(savedMoney);
                    minBudgetNeeded -= savings;

                    if (minBudgetNeeded <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        endLoop = true;
                    }

                }
                if (savedMoney == "End")
                {
                    break;
                }

                destination = Console.ReadLine();
            }
        }
    }
}
