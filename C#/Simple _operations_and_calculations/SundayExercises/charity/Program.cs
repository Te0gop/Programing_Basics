using System;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int numOfCakes = int.Parse(Console.ReadLine());
            int numOfWaffles = int.Parse(Console.ReadLine());
            int numOfPancakes = int.Parse(Console.ReadLine());
            double cakesProfit = numOfCakes * 45;
            double wafflesProfit = numOfWaffles * 5.80;
            double pancakesProfit = numOfPancakes * 3.20;
            double totalProfit1day = (cakesProfit + wafflesProfit + pancakesProfit) * bakers;
            double total = days * totalProfit1day;
            total = total - total * 1 / 8;
            Console.WriteLine($"{total:F2}");
        }
    }
}
