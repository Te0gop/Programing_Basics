using System;

namespace FishLand
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());
            double palamudPrice = (skumPrice + (skumPrice * 0.6)) * palamudKg;
            double safridPrice = (cacaPrice + (cacaPrice * 0.8)) * safridKg;
            double midiPrice = midiKg * 7.5;
            double result = palamudPrice + safridPrice + midiPrice;
            Console.WriteLine($"{result:F2}");
        }
    }
}