using System;
namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double sideArea = ((x * y) - (1.5 * 1.5)) * 2;
            double frontBackSides = (x * x) * 2 - (2 * 1.2);
            double greenPaint = (sideArea + frontBackSides) / 3.4;
            double rectangle = (x * y) * 2;
            double triangle = (x * h / 2) * 2;
            double roof = rectangle + triangle;
            double redPaint = roof / 4.3;
            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
