using System;

namespace TilesChanging
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());
            double playground = N * N;
            double tiles = W * L;
            double bench = M * O;
            double tilesNeeded = playground - bench;
            double All = tilesNeeded / tiles;
            double time = All * 0.2;
            Console.WriteLine(All);
            Console.WriteLine(time);

        }
    }
}
