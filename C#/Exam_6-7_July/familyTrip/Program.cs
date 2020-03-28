using System;

namespace familyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nights > 7)
            {
                priceForNight -= priceForNight * 0.05;
            }

            double priceForAllNights = nights * priceForNight;
            double percentSum = percent * budget / 100;
            double totalPrice = priceForAllNights + percentSum;

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalPrice:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:f2} leva needed.");
            }
        }
        
    }
}
