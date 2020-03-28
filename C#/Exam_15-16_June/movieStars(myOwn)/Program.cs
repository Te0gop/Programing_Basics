using System;

namespace movieStars_myOwn_
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string actorName = Console.ReadLine();
            double diff = 0;
            bool leftMoney = true;


            while (actorName != "ACTION")
            {
                if (actorName.Length > 15)
                {
                    budget -= (budget * 0.20);
                }
                else
                {
                    double salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                }
                if (budget <= 0)
                {
                    diff = Math.Abs(budget);
                    leftMoney = false;
                    break;
                }

                actorName = Console.ReadLine();
            }

            if (!leftMoney)
            {
                Console.WriteLine($"We need {diff:f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
