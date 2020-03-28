using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string unitOne = Console.ReadLine();
            string unitTwo = Console.ReadLine();

            if (unitOne == "mm")
            {
                if (unitTwo == "m")
                {
                    double result = number / 1000;
                    Console.WriteLine($"{result:F3}");
                }
                else if (unitTwo == "cm")
                {
                    double result = number / 10;
                    Console.WriteLine($"{result:F3}");
                }
                else
                {
                    Console.WriteLine($"{number:F3}");
                }

            }
            else if (unitOne == "m")
            {
                if (unitTwo == "cm")
                {
                    double resultM = number * 100;
                    Console.WriteLine($"{resultM:F3}");
                }
                else if (unitTwo == "mm")
                {
                    double resultM = number * 1000;
                    Console.WriteLine($"{resultM:F3}");
                }
                else 
                {
                    Console.WriteLine($"{number:F3}");
                }

            }
            else if (unitOne == "cm")
            {
                if (unitTwo == "m")
                {
                    double resultCM = number / 100;
                    Console.WriteLine($"{resultCM:F3}");
                }
                else if (unitTwo == "mm")
                {
                    double resultCM = number * 10;
                    Console.WriteLine($"{resultCM:F3}");
                }
                else 
                {
                    Console.WriteLine($"{number:F3}");
                }

            }

        }

    }
}   