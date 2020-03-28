using System;

namespace christmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int horrorBooks = int.Parse(Console.ReadLine());
            int romanticBooks = int.Parse(Console.ReadLine());

            double income = (fantasyBooks * 14.90) + (horrorBooks * 9.80) + (romanticBooks * 4.3);
            income *= 0.8;

            if (income >= target)
            {
                double profit = income - target;
                double pay = Math.Floor(profit * 0.10);

                income -= pay;
                Console.WriteLine($"{income:F2} leva donated.");
                Console.WriteLine($"Sellers will receive {pay} leva.");
            }
            else
            {
                double diff = target - income;
                Console.WriteLine($"{diff:F2} money needed.");
            }
        }
    }
}
