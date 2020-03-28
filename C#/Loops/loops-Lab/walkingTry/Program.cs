using System;

namespace walkingTry
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int totalSteps = 0;
            

            while (steps != "Going home")
            {
                totalSteps += int.Parse(steps);

                if (totalSteps >= 10000)
                {
                    break;
                }

                steps = Console.ReadLine();

            }

            if (steps == "Going home")
            {
                int stepsBackToHome = int.Parse(Console.ReadLine());

                if (totalSteps + stepsBackToHome >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{10000 - totalSteps - stepsBackToHome} more steps to reach goal.");
                }

            }
            else if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }


        }
        
    }
}
