using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
  

            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    p1++;
                }
                if (n % 3 == 0)
                {
                    p2++;
                }
                if (n % 4 == 0)
                {
                    p3++;
                }

            }
            Console.WriteLine($"{p1 * 1.0 / numbers * 100:f2}%");
            Console.WriteLine($"{p2 * 1.0 / numbers * 100:f2}%");
            Console.WriteLine($"{p3 * 1.0 / numbers * 100:f2}%");
        }
    }
}
