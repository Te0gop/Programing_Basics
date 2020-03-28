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
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 200)
                {
                    p1++;
                }
                else if (n < 400)
                {
                    p2++;
                }
                else if (n < 600)
                {
                    p3++;
                }
                else if (n < 800)
                {
                    p4++;
                }
                else if (n >= 800)
                {
                    p5++;
                }

            }
            Console.WriteLine($"{p1 * 1.0 / numbers * 100:f2}%");
            Console.WriteLine($"{p2 * 1.0 / numbers * 100:f2}%");
            Console.WriteLine($"{p3 * 1.0 / numbers * 100:f2}%");
            Console.WriteLine($"{p4 * 1.0 / numbers * 100:f2}%");
            Console.WriteLine($"{p5 * 1.0 / numbers * 100:f2}%");
        }
    }
}
