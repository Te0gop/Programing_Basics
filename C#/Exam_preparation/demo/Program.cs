using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            double baklavaPriceKg = double.Parse(Console.ReadLine());
            double muffinsPriceKg = double.Parse(Console.ReadLine());
            double shtolenKg = double.Parse(Console.ReadLine());
            double candyKg = double.Parse(Console.ReadLine());
            int biscuitsKg = int.Parse(Console.ReadLine());

            double biscuitPrice = biscuitsKg * 7.5;
            double candiesPrice = candyKg * (1.8 * muffinsPriceKg);
            double shtolenPrice = (baklavaPriceKg * 1.6) * shtolenKg;
            double totalPrice = biscuitPrice + candiesPrice + shtolenPrice;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
