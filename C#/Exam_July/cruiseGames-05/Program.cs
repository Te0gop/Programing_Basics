using System;

namespace cruiseGames_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string playersName = Console.ReadLine();
            int playedGames = int.Parse(Console.ReadLine());

            double volley = 0;
            double tennis = 0;
            double badminton = 0;
            int volleyCounter = 0;
            int tennisCounter = 0;
            int badCounter = 0;


            for (int i = 0; i < playedGames; i++)
            {
                string gamesName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                switch (gamesName)
                {
                    case "volleyball":
                        volley += points * 1.07;
                        volleyCounter++;
                        break;
                    case "tennis":
                        tennis += points * 1.05;
                        tennisCounter++;
                        break;
                    case "badminton":
                        badminton += points * 1.02;
                        badCounter++;
                        break;
                }

            }
            double totalPoints = volley + tennis + badminton;


            if (volley / volleyCounter >= 75 && tennis / tennisCounter >= 75 && badminton / badCounter >= 75)
            {
                Console.WriteLine($"Congratulations, {playersName}! You won the cruise games with {Math.Floor(totalPoints)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {playersName}, you lost. Your points are only {Math.Floor(totalPoints)}.");
            }
        }
    }
}