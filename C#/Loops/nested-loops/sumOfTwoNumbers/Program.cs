using System;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerLimit = int.Parse(Console.ReadLine());
            int upperLimit = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combCount = 0;
            bool hasMagicCombination = false;

            for (int i = lowerLimit; i <= upperLimit; i++)
            {
                for (int j = lowerLimit; j <= upperLimit; j++)
                {
                    combCount++;
                    int currentSum = i + j;

                    if (currentSum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combCount} ({i} + {j} = {currentSum})");
                        hasMagicCombination = true;
                        break;
                    }
                }
                if (hasMagicCombination)
                {
                    break;
                }
            }
            if (!hasMagicCombination)
            {
                Console.WriteLine($"{combCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
