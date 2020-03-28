using System;

namespace movieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string actorName = Console.ReadLine();
            bool endBudget = false;

            while (actorName != "ACTION")
            {
                string actor = actorName;
                double salary = 0;
                if (actor.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                }
                else
                {
                    salary = 0.20 * budget;
                }
                budget -= salary;
                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    endBudget = true;
                    break;
                }
                actorName = Console.ReadLine();
            }
            if (!endBudget)
            {
                Console.WriteLine($"We are left with {budget:F2} leva.");
            }

        }
    }
}
