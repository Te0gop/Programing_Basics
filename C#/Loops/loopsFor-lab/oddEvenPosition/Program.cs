using System;

namespace oddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int counter = numbers;
            int oddSum = 0;
            int oddMin = 0;
            int oddMax = 0;
            int evenSum = 0;
            int evenMin = 0;
            int evenMax = 0;


            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (counter % 2 == 0)
                {
                    evenSum += n;

                    if (n > evenMax)
                    {
                        evenMax = n;
                    }
                    else if (n < evenMax)
                    {

                    }
                }
                else
                {
                    oddSum += n;
                }






            }
        }
    }
}
