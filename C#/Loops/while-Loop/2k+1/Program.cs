using System;

namespace _2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int variable = 1;

            while (variable <= number)
            {
                Console.WriteLine(variable);
                variable = variable * 2 + 1;
            }
        }
    }
}
