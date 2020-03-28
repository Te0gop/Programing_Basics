using System;

namespace weddingPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int presentsCount = int.Parse(Console.ReadLine());

            int catA = 0;
            int catB = 0;
            int catV = 0;
            int catG = 0;

            for (int i = 0; i < presentsCount; i++)
            {
                string category = Console.ReadLine();

                switch (category)
                {
                    case "A":
                        catA++;
                        break;
                    case "B":
                        catB++;
                        break;
                    case "V":
                        catV++;
                        break;
                    case "G":
                        catG++;
                        break;
                }

            }
            Console.WriteLine($"{catA * 1.0 / presentsCount * 100:F2}%");
            Console.WriteLine($"{catB * 1.0 / presentsCount * 100:F2}%");
            Console.WriteLine($"{catV * 1.0 / presentsCount * 100:F2}%");
            Console.WriteLine($"{catG * 1.0 / presentsCount * 100:F2}%");
            Console.WriteLine($"{presentsCount * 1.0 / guests * 100.0:F2}%");

        }
    }
}
