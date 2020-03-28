using System;

namespace renovation
{
    class Program
    {
        static void Main(string[] args)
        {

            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percentOfUnpainted = double.Parse(Console.ReadLine());

            double paintingArea = height * width * 4;
            paintingArea -= paintingArea * (percentOfUnpainted / 100);
            string paintLiters = Console.ReadLine();

            while (paintLiters != "Tired!")
            {
                int liters = int.Parse(paintLiters);
                paintingArea -= liters;

                if (paintingArea < 0)
                {
                    break;
                }
                else if (paintingArea == 0)
                {
                    break;
                }

                paintLiters = Console.ReadLine();
            }
            if (paintingArea > 0)
            {
                Console.WriteLine($"{paintingArea} quadratic m left.");
            }
            else if (paintingArea < 0)
            {
                paintingArea = Math.Abs(paintingArea);
                Console.WriteLine($"All walls are painted and you have {paintingArea} l paint left!");
            }
            else
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }

        }
    }
}
