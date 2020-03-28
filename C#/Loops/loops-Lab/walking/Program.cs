using System;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;

            while (input != "Going home")
            {
                totalSteps += int.Parse(input);

                if (totalSteps >= 10000)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalSteps += stepsToHome;
            }
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more to reach goal.");

            }


        }
    }
}
