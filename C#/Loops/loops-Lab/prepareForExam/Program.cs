using System;

namespace prepareForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string poorGrades = Console.ReadLine();

            int counter = 0;
            double gradeSum = 0;
            int badGradeCounter = 0;
            string exerciseName = string.Empty;
            string lastProblem = " ";

            while (exerciseName != "Enough")
            {
                exerciseName = Console.ReadLine();
                int poorGrade = int.Parse(poorGrades);

                if (exerciseName == "Enough")
                {
                    break;
                }

                lastProblem = exerciseName;
                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;

                if (grade <= 4)
                {
                    badGradeCounter++;
                }

                if (badGradeCounter == poorGrade)
                {
                    break;
                }

                counter++;
            }

            if (exerciseName == "Enough")
            {
                Console.WriteLine($"Average score: {gradeSum / counter:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

            else 
            {
                Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
            }

        }
    }
}
