using System;

namespace numberNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int counter = number;

            for (int i = counter; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
