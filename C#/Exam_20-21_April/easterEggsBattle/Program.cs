using System;

namespace easterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsFirstPlayer = int.Parse(Console.ReadLine());
            int eggsSecondPlayer = int.Parse(Console.ReadLine());

            string winner = Console.ReadLine();

            while (winner != "End of battle")
            {

                if (winner == "one")
                {
                    eggsSecondPlayer--;
                }
                else if (winner == "two")
                {
                    eggsFirstPlayer--;
                }

                if (eggsSecondPlayer == 0 || eggsFirstPlayer == 0)
                {
                    break;
                }


                winner = Console.ReadLine();
            }
            if (eggsFirstPlayer == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondPlayer} eggs left.");
            }
            else if (eggsSecondPlayer == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
            }
            else
            {
                Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsSecondPlayer} eggs left.");
            }


        }
    }
}
