using System;

namespace oddOReven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            int total = 0;
            int counter = number;
            
            for (int i = 0; i < number; i++)
            {
                total = int.Parse(Console.ReadLine());

                if (counter % 2 != 0)
                {
                    oddSum += total;
                }
                else
                {
                    evenSum += total;
                }
                counter--;

                if (counter == 0)
                {
                    break;
                }
            }

            if (oddSum == evenSum)
            {
                int totalSum = Math.Abs(oddSum);
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {totalSum}");
            }
            else
            {
                int totalSum = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {totalSum}");
            }



        }
    }
}
