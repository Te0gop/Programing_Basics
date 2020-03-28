using System;

namespace footballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int numberOfgames = int.Parse(Console.ReadLine());

            int counterWin = 0;
            int counterD = 0;
            int counterLose = 0;

            for (int i = 0; i < numberOfgames; i++)
            {
                string gameResult = Console.ReadLine();

                if (gameResult == "W")
                {
                    counterWin++;
                }
                else if (gameResult == "D")
                {
                    counterD++;
                }
                else if (gameResult == "L")
                {
                    counterLose++;
                }
            }

            if (numberOfgames == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                int counterWinPoints = counterWin * 3;
                Console.WriteLine($"{teamName} has won {counterWinPoints + counterD} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {counterWin}");
                Console.WriteLine($"## D: {counterD}");
                Console.WriteLine($"## L: {counterLose}");
                Console.WriteLine($"Win rate: {(counterWin * 1.0 / numberOfgames * 100):f2}%");
            }

        }
    }
}
