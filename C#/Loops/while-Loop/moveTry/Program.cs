using System;

namespace moveTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            
            int freeSpace = width * lenght * height;
            int totalBoxes = 0;
            string enough = Console.ReadLine();
            
            while (enough != "Done")
            {
                int numOfBoxes = int.Parse(enough);
                totalBoxes += numOfBoxes;

                if (totalBoxes > freeSpace)
                {
                    break;
                }
                enough = Console.ReadLine();
            }
            if (freeSpace > totalBoxes)
            {
                int moreSpace = freeSpace - totalBoxes;
                Console.WriteLine($"{moreSpace} Cubic meters left.");
            }
            
            else
            {
                int spaceNeeded = totalBoxes - freeSpace;
                Console.WriteLine($"No more free space! You need {spaceNeeded} Cubic meters more.");

            }


        }
    }
}
