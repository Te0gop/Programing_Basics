using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double hTriangle = double.Parse(Console.ReadLine());
            double triangleArea = side * hTriangle / 2;
            Console.WriteLine($"{triangleArea:F2}");
        }
    }
}
