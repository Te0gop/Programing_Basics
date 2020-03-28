using System;

namespace christmasTournament_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentDays = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            int totalWins = 0;
            int totalLoses = 0;

            for (int i = 0; i < tournamentDays; i++)
            {

                int winCounter = 0;
                int loseCounter = 0;
                double charityMoney = 0;
                string gameName = Console.ReadLine();

                while (gameName != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        winCounter++;
                        charityMoney += 20;
                    }
                    else
                    {
                        loseCounter++;
                    }

                    gameName = Console.ReadLine();
                }

                if (winCounter > loseCounter)
                {
                    charityMoney *= 1.10;
                    totalWins += winCounter;
                }
                else
                {
                    totalLoses += loseCounter;
                }
                totalMoney += charityMoney;
            }
            if (totalWins > totalLoses)
            {
                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");
            }
        }
    }
}
