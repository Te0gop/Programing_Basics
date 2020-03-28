using System;

namespace summerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double umbrella = (towelPrice * 2) / 3.0;
            double flipFlops = umbrella * 0.75;
            double bag = (towelPrice + flipFlops) / 3.0;
            double price = towelPrice + umbrella + bag + flipFlops;
            double diffrence = price * discount / 100.0;
            double allPrice = price - diffrence;
            

            if (budget >= price)
            {
                double ats = (budget - allPrice);
                Console.WriteLine($"Annie's sum is {allPrice:f2} lv. She has {ats:f2} lv. left.");
            }
            else if (price > budget)
            {
                double ats = (allPrice - budget);
                Console.WriteLine($"Annie's sum is {allPrice:f2} lv. She needs {ats:f2} lv. more.");

            }
        }
    }
}
