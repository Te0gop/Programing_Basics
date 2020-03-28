using System;

namespace Trapezoid_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var a1 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + a1) * h / 2;
            Console.WriteLine("Trapezoid area = " + area);

        }
    }
}
