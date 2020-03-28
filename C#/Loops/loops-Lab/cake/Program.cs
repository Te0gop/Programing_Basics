using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int totalPieces = width * lenght;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                totalPieces -= int.Parse(input);

                if (totalPieces < 0)
                {
                    Console.WriteLine($"No more cake left. You need {Math.Abs(totalPieces)}");
                    break;
                }

                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }

        }
    }
}
