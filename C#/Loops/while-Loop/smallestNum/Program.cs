using System;

namespace smallestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int minNumber = 0;
            int result = 1000000000;

            while (minNumber < number)
            {
                int minValue = int.Parse(Console.ReadLine());
                if (minValue < result)
                {
                    result = minValue;
                }
                minNumber++;
            }
            Console.WriteLine(result);


        }
    }
}
