using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLv = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double excelentScolarship = grade * 25;
            double socialSclolarship = minSalary * 0.35;

            if (incomeLv < minSalary && grade > 4.5 && grade <= 5.49)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor (socialSclolarship)} BGN");
            }
            else if (incomeLv < minSalary && grade > 4.5)
            {
                if (socialSclolarship > excelentScolarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor (socialSclolarship)} BGN");
                }
                else if (excelentScolarship > socialSclolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor (excelentScolarship)} BGN");
                }
                else if (excelentScolarship == socialSclolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor (excelentScolarship)} BGN");
                }
            }
            else if (grade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor (excelentScolarship)} BGN");
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


        }
    }
}
