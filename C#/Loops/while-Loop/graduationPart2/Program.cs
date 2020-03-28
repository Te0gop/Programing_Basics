using System;

namespace graduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double gradesPlus = 0;
            double gradeCounter = Math.Abs(0);
            int badGradeCounter = 0;

            while (gradeCounter < 12 && badGradeCounter <= 1)
            {
                double grades = double.Parse(Console.ReadLine());

                if (grades >= 4 && grades <= 6)
                {
                    gradesPlus += grades;
                    gradeCounter++;
                    badGradeCounter = 0;
                }
                else if (4 > grades)
                {
                    gradesPlus += grades;
                    badGradeCounter++;
                    gradeCounter++;
                }

            }

            if (badGradeCounter > 1)
            {
                Console.WriteLine($"{name} has been excluded at {gradeCounter - 1} grade");
            }
            else
            {
                gradesPlus /= gradeCounter;
                Console.WriteLine($"{name} graduated. Average grade: {gradesPlus:f2}");
            }

        }
    }

}
