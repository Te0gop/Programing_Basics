using System;

namespace examMove
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int totalVolume = width * lenght * hight;
            int totalBoxCount = 0;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                int currentBoxes = int.Parse(input);
                totalBoxCount += currentBoxes;

                if (totalBoxCount > totalVolume)
                {

                    break;
                }
                input = Console.ReadLine();
            }
            if (totalBoxCount > totalVolume)
            {
                int needSpace = totalBoxCount - totalVolume;
                Console.WriteLine($"No more free space! You need {needSpace} cubic meters more");
            }
            else
            {
                int freeSpace = totalVolume - totalBoxCount;
                Console.WriteLine($"{freeSpace} cubic meters left.");
            }



        }
    }
}
