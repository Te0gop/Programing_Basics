using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());
            double costs = income * 30 / 100;
            double savings = income - moneyNeeded - costs;
            double percent = savings / income * 100;
            double money = months * savings;
            Console.WriteLine($"She can save {percent:F2}%");
            Console.WriteLine($"{money:F2}");
        }
    }
}
