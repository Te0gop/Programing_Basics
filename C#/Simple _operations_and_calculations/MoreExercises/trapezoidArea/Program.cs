using System;

namespace trapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegPrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());
            double vegPriceKgs = vegPrice * vegKg;
            double fruitPriceKgs = fruitPrice * fruitKg;
            double result = (vegPriceKgs + fruitPriceKgs) / 1.94;
            Console.WriteLine($"{result:F2}");



        }
    }
}
