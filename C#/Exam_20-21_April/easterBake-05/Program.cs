using System;

namespace easterBake_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());

            int sugarMax = int.MinValue;
            int flourMax = int.MinValue;
            int sugarQuantity = 0;
            int flourQuantity = 0;

            for (int i = 0; i < easterBread; i++)
            {
                int sugarGr = int.Parse(Console.ReadLine());
                int flourGr = int.Parse(Console.ReadLine());

                sugarQuantity += sugarGr;
                flourQuantity += flourGr;

                if (sugarGr > sugarMax)
                {
                    sugarMax = sugarGr;
                }
                if (flourGr > flourMax)
                {
                    flourMax = flourGr;
                }

            }

            double sugarPackage = Math.Ceiling(sugarQuantity / 950.0);
            double flourPackage = Math.Ceiling(flourQuantity / 750.0);

            Console.WriteLine($"Sugar: {sugarPackage}");
            Console.WriteLine($"Flour: {flourPackage}");
            Console.WriteLine($"Max used flour is {flourMax} grams, max used sugar is {sugarMax} grams.");
        }
    }
}
