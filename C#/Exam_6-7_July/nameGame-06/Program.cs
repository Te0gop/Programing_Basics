using System;

namespace nameGame_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int bestPoints = 0;
            string bestPlayerName = string.Empty;

            while (playerName != "Stop")
            {
                int totalPoints = 0;

                for (int i = 0; i < playerName.Length; i++)
                {
                    int ASCII = playerName[i];
                    int number = int.Parse(Console.ReadLine());

                    if (number == ASCII)
                    {
                        totalPoints += 10;
                    }
                    else
                    {
                        totalPoints += 2;
                    }
                    if (totalPoints >= bestPoints)
                    {
                        bestPoints = totalPoints;
                        bestPlayerName = playerName;
                    }
                }

                playerName = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {bestPlayerName} with {bestPoints} points!");
        }
    }
}
