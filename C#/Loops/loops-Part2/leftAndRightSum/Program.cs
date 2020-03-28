using System;

namespace leftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                sum = int.Parse(Console.ReadLine());
                leftSum += sum;
            }
            for (int i = 0; i < numbers; i++)
            {
                sum = int.Parse(Console.ReadLine());
                rightSum += sum;
            }

            if (rightSum == leftSum) 
            {
                Console.WriteLine("Yes, sum = " + rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
