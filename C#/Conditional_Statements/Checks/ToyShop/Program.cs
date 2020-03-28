using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double trip = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double puzzlePrice = puzzles * 2.60;
            int dollsPrice = dolls * 3;
            double bearsPrice = teddyBears * 4.10;
            double minionsPrice = minions * 8.20;
            int trucksPrice = trucks * 2;
            double totalPrice = puzzlePrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;
            int toys = puzzles + dolls + teddyBears + minions + trucks;
            totalPrice = totalPrice - (totalPrice * 0.10);

            if (toys >= 50)
            {
              totalPrice = totalPrice - (totalPrice * 0.25);
            }
            if (totalPrice >= trip)
            { 
                Console.WriteLine($"Yes! {(totalPrice - trip):F2} lv left.");
            } 
            else
            {
                Console.WriteLine($"Not enough money! {(trip - totalPrice):F2} lv needed.");
            }
        }
    }
}
