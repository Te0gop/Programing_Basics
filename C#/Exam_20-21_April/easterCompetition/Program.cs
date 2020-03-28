using System;

namespace easterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());

            string bestBaker = string.Empty;
            int bestBakerPoints = int.MinValue;


            for (int i = 0; i < easterBread; i++)
            {
                string bakerName = Console.ReadLine();
                string grade = Console.ReadLine();
                int points = 0;

                while (grade != "Stop")
                {
                    points += int.Parse(grade);
                    grade = Console.ReadLine();
                }

                Console.WriteLine($"{bakerName} has {points} points.");

                if (points > bestBakerPoints)
                {
                    bestBakerPoints = points;
                    bestBaker = bakerName;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                }

            }
            Console.WriteLine($"{bestBaker} won competition with {bestBakerPoints} points!");


        }
    }
}
