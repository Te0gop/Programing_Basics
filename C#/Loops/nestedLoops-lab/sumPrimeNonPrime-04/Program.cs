using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;


            while (input != "stop")
            {
                int current = int.Parse(input);
                if (current < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isNonPrime = false;
                int m = current / 2;
                for (int i = 2; i <= m; i++)
                {
                    if (current % i == 0)
                    {
                        isNonPrime = true;
                        break;
                    }
                }

                if (isNonPrime)
                {
                    sumNonPrime += current;
                }
                else
                {
                    sumPrime += current;
                }

                input = Console.ReadLine();
            }


            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");

        }
    }
}