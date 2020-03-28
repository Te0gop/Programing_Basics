using System;

namespace safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string dayOfweekend = Console.ReadLine();

            double fuelPrice = fuel * 2.10;
            double guide = 100;
            double totalPrice = fuelPrice + guide;

            switch (dayOfweekend)
            {
                case "Saturday":
                    totalPrice -= totalPrice * 0.10;
                    break;
                case "Sunday":
                    totalPrice -= totalPrice * 0.20;
                    break;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - totalPrice:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {totalPrice - budget:f2} lv.");
            }
        }
    }
}
