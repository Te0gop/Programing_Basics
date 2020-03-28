using System;

namespace gameOfIntervals_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double sumOfNumbers = 0;
            int from0to9 = 0;
            int from10to19 = 0;
            int from20to29 = 0;
            int from30to39 = 0;
            int from40to50 = 0;
            int invalidNumbers = 0;

            for (int i = 0; i < moves; i++)
            {
                int numbersOfIntervals = int.Parse(Console.ReadLine());

                if (numbersOfIntervals >= 0 && numbersOfIntervals <= 9)
                {
                    sumOfNumbers += numbersOfIntervals * 0.20;
                    from0to9++;
                }
                else if (numbersOfIntervals >= 10 && numbersOfIntervals <= 19)
                {
                    sumOfNumbers += numbersOfIntervals * 0.30;
                    from10to19++;
                }
                else if (numbersOfIntervals >= 20 && numbersOfIntervals <= 29)
                {
                    sumOfNumbers += numbersOfIntervals * 0.40;
                    from20to29++;
                }
                else if (numbersOfIntervals >= 30 && numbersOfIntervals <= 39)
                {
                    sumOfNumbers += 50;
                    from30to39++;
                }
                else if (numbersOfIntervals >= 40 && numbersOfIntervals <= 50)
                {
                    sumOfNumbers += 100;
                                   from40to50++;
                }
                else
                {
                    sumOfNumbers /= 2;
                    invalidNumbers++;
                }

            }

            Console.WriteLine($"{sumOfNumbers:F2}");
            Console.WriteLine($"From 0 to 9: {from0to9 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 10 to 19: {from10to19 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 20 to 29: {from20to29 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 30 to 39: {from30to39 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"From 40 to 50: {from40to50 * 1.0 / moves * 100:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers * 1.0 / moves * 100:F2}%");
        }
    }
}
