using System;

namespace sumOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int numberFor = int.Parse(Console.ReadLine());
                sum += numberFor;
            }
            Console.WriteLine(sum);


        }
    }
}
