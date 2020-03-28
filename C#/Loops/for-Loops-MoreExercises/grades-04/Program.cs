using System;

namespace grades_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            double allGrades = 0;
            int poor = 0;
            int good = 0;
            int veryGood = 0;
            int excellent = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double studentsGrade = double.Parse(Console.ReadLine());

                if (studentsGrade >= 2 && studentsGrade < 3)
                {
                    allGrades += studentsGrade;
                    poor++;
                }
                else if (studentsGrade >= 3 && studentsGrade < 4)
                {
                    allGrades += studentsGrade;
                    good++;
                }
                else if (studentsGrade >= 4 && studentsGrade < 5)
                {
                    allGrades += studentsGrade;
                    veryGood++;
                }
                else if (studentsGrade >= 5)
                {
                    allGrades += studentsGrade;
                    excellent++;
                }

            }

            double averageExamGrade = allGrades / numberOfStudents;

            Console.WriteLine($"Top students: {excellent * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGood * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {good * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Fail: {poor * 1.0 / numberOfStudents * 100:f2}%");
            Console.WriteLine($"Average: {averageExamGrade:f2}");
        }
    }
}
