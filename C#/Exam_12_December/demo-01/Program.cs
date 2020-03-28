using System;

namespace demo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double suveniersMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double LitersfuelNeeded = 420.00 / 100 * 7;
            double fuelPrice = LitersfuelNeeded * 1.85;
            double foodAndSuveniersMoney = 3 * foodMoney + 3 * suveniersMoney;
            double firstDayDiscount = hotelMoney * 0.90;
            double secondDayDiscount = hotelMoney * 0.85;
            double thirdDayDiscount = hotelMoney * 0.80;

            double totalMoney = fuelPrice + foodAndSuveniersMoney + firstDayDiscount + secondDayDiscount + thirdDayDiscount;

            Console.WriteLine($"Money needed: {totalMoney:F2}");





        }
    }
}
