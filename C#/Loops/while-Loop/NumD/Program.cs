using System;

namespace NumD
{
    class Program
    {
        static void Main(string[] args)
        {  

            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");

            }
            Console.WriteLine(number);
        }
    }
}
