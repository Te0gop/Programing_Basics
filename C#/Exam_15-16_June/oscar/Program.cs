using System;

namespace oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double actorsPoints = pointsFromAcademy;

            for (int i = 0; i < judges; i++)
            {
                string judgeName = Console.ReadLine();
                double pointsFromJudge = double.Parse(Console.ReadLine());

                actorsPoints += judgeName.Length * pointsFromJudge / 2;

                if (actorsPoints > 1250.5)
                {
                    break;
                }

            }
            if (actorsPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {actorsPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorsName} you need {1250.5 - actorsPoints:f1} more!");
            }


        }
    }
}
