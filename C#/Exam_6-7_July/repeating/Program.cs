using System;

namespace repeating
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hoursNeeded = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon * 1.50) + (2.0 * 1.5);
            double paintPrice = paint * 14.50 + (paint * 0.10 * 14.50);
            double diluentPrice = diluent * 5.00;
            double bagsPrice = 0.40;

            double totalPrice = nylonPrice + paintPrice + diluentPrice + bagsPrice;
            double hoursPrice = totalPrice * 0.30 * hoursNeeded;
            double allPrice = hoursPrice + totalPrice;
            Console.WriteLine($"Total expenses: {allPrice:f2} lv.");


        }
    }
}
