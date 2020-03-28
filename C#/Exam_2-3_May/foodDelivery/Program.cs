using System;

namespace foodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegnMenu = int.Parse(Console.ReadLine());

            double totalPrice = (chickenMenu * 10.35) + (fishMenu * 12.40) + (vegnMenu * 8.15);
            double desert = totalPrice * 0.20;
            totalPrice += desert + 2.50;

            Console.WriteLine($"Total: {totalPrice:f2}");
        }
    }
}
