using System;

namespace easterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsNum = int.Parse(Console.ReadLine());

            int biggestNum = int.MinValue;
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;

            for (int i = 0; i < eggsNum; i++)
            {
                string eggColor = Console.ReadLine();

                if (eggColor == "red")
                {
                    red++;
                }
                else if (eggColor == "orange")
                {
                    orange++;
                }
                else if (eggColor == "blue")
                {
                    blue++;
                }
                else if (eggColor == "green")
                {
                    green++;
                }
            }
            string color = string.Empty;

            if (red > biggestNum)
            {
                biggestNum = red;
                color = "red";
                
            }
            if (orange > biggestNum)
            {
                biggestNum = orange;
                color = "orange";
            }
            if (blue > biggestNum)
            {
                biggestNum = blue;
                color = "blue";
            }
            if (green > biggestNum)
            {
                biggestNum = green;
                color = "green";
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {biggestNum} -> {color}");
        }
    }
}
