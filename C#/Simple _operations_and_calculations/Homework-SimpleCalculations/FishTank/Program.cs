using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = lenght * width * hight;
            double liters = volume / 1000;
            double percent1 = percent / 100;
            double percent2 = 1 - percent1;
            double result = liters * percent2;
            Console.WriteLine("{0:F3}", result);


        }
    }
}