using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double lemonsKg = double.Parse(Console.ReadLine());
            double sugarKg = double.Parse(Console.ReadLine());
            double waterL = double.Parse(Console.ReadLine()) * 1000;

            double lemonsJuice = lemonsKg * 980;
            double lemonade = lemonsJuice + waterL;
            lemonade += sugarKg * 0.3;
            double cups = Math.Floor(lemonade / 150);
            double profit = cups * 1.2;

            Console.WriteLine("All cups sold: {0}", cups);
            Console.WriteLine($"Money earned: {profit:f2}");

        }
    }
}
