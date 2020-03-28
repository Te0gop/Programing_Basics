using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalSum = 0;
            int numberOfContestants = 0;    
            string input = Console.ReadLine();

            while (input != "Finish")
            {
                double sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }
                double averageGrade = sum / n;
                totalSum += averageGrade;

                Console.WriteLine($"{input} - {averageGrade:f2}.");
               numberOfContestants++;
                input = Console.ReadLine();
            }
            double totalAverageGrade = totalSum / numberOfContestants;
            Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}." );


        }
    }
}
