using System;

namespace trainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double width = ((h * 100) - 100) / 70;
            double widthR = Math.Floor(width);
            double lenght = Math.Floor(w * 100) / 120;
            double lenghtR = Math.Floor(lenght);
            Console.WriteLine(widthR * lenghtR - 3);

        }
    }
}
