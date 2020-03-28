using System;

namespace cakeTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cake = width * lenght;
            string loopEnd = Console.ReadLine();
            int piecesSum = 0;

            while (loopEnd != "STOP")
            {
                int pieces = int.Parse(loopEnd);
                piecesSum += pieces;

                if (piecesSum > cake)
                {
                    break;
                }

                loopEnd = Console.ReadLine();

            }

            if (loopEnd == "STOP")
            {
                Console.WriteLine($"{cake - piecesSum} pieces are left.");
            }
            else if (piecesSum > cake)
            {
                Console.WriteLine($"No more cake left! You need {piecesSum - cake} pieces more.");
            }




        }
    }
}
