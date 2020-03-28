using System;

namespace danceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double hall = L * W;
            double gard = Math.Pow(A, 2);
            double bench = hall / 10;
            double freeSpace = hall - gard - bench;
            freeSpace = freeSpace * 10000;
            double dancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
