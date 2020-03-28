using System;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numOfgrades = 0;
            double gradeSum = 0;
            
            while (numOfgrades < 12)
            {
                double gradeValue = double.Parse(Console.ReadLine());
                if (gradeValue >= 4 && gradeValue <= 6)
                {
                    gradeSum += gradeValue;
                    numOfgrades++;
                }
            }

            gradeSum /= numOfgrades;

            if (gradeSum >= 4)
            {
                Console.WriteLine($"{name} graduated. Average grade: {gradeSum:f2}");
            }

        }
    }
}
