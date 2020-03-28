using System;

namespace pcGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;

            for (int i = 0; i < soldGames; i++)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    counter1++;
                }
                else if (gameName == "Fornite")
                {
                    counter2++;
                }
                else if (gameName == "Overwatch")
                {
                    counter3++;
                }
                else
                {
                    counter4++;
                }

            }

            Console.WriteLine($"Hearthstone - {counter1 / soldGames * 100:f2}%");
            Console.WriteLine($"Fornite - {counter2 / soldGames * 100:f2}%");
            Console.WriteLine($"Overwatch - {counter3 / soldGames * 100:f2}%");
            Console.WriteLine($"Others - {counter4 / soldGames * 100:f2}%");

        }
    }
}
