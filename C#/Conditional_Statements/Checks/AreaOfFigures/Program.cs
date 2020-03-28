using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            if (typeOfFigure == "square")
            {
                double area = double.Parse(Console.ReadLine());
                double result = area * area;
                Console.WriteLine($"{result:F3}");
            }
            else if (typeOfFigure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = sideA * sideB;
                Console.WriteLine($"{result:F3}");
            }
            else if (typeOfFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double result = Math.PI * r * r ;
                Console.WriteLine($"{result:F3}");
            }
            else if (typeOfFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double result = side * h / 2;
                Console.WriteLine($"{result:F3}");
            }

        }
    }
}
