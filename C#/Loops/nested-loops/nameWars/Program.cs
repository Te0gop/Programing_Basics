using System;

namespace nameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int winnerPoints = int.MinValue;
            string winnerName = string.Empty;

            while (name != "STOP")
            {
                int result = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    result += ((int)name[i]);

                }
                if (result > winnerPoints)
                {
                    winnerPoints = result;
                    winnerName = name;
                }

                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winnerName} - {winnerPoints}!");
        }
    }
}
