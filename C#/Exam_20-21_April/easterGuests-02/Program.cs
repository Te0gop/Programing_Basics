using System;

namespace easterGuests_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double easterBread = Math.Ceiling(guests / 3.0);
            double eggs = guests * 2;
            double easterBreadPrice = easterBread * 4;
            double eggsPrice = eggs * 0.45;
            double totalPrice = (eggsPrice + easterBreadPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Lyubo bought {easterBread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget-totalPrice:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalPrice-budget:f2} lv. more.");
            }
        }
    }
}
