using System;

namespace excercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());
            double barSide = double.Parse(Console.ReadLine());

            double hallSize = lenghtHall * widthHall;
            double barSize = barSide * barSide;
            double dancingSize = hallSize * 0.19;
            double freeSpace = hallSize - barSize - dancingSize;
            double guests = freeSpace / 3.2;

            Console.WriteLine(Math.Ceiling(guests));

        }
    }
}
