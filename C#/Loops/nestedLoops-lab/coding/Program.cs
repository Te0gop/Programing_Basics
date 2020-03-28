using System;

namespace coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();

            for (int i = inputNum.Length - 1; i >= 0; i--)
            {
                char currentDigit = inputNum[i];
                int currentDigitNumber = int.Parse(currentDigit.ToString());

                if (currentDigitNumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int n = 1; n <= currentDigitNumber; n++)
                {
                    Console.Write((char)(currentDigitNumber + 33));
                }
                Console.WriteLine();
            }
        }
    }
}
