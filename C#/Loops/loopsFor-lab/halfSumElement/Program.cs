using System;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfNumbers = 0;
            int biggestNum = 0;

            for (int i = 0; i < number; i++)
            {

                int n = int.Parse(Console.ReadLine());

                if (n > biggestNum)
                {
                    biggestNum = n;
                }
                sumOfNumbers += n;
            }

            int diffrence = sumOfNumbers - biggestNum;

            if (diffrence == biggestNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + Math.Abs(diffrence));
            }
            else
            {
                int ats = biggestNum - diffrence;
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(ats));

            }
        }
    }
}
