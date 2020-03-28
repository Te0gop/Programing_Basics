using System;

namespace easterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            double pricePerMan = double.Parse(Console.ReadLine());
            double desiSbudget = double.Parse(Console.ReadLine());

            if (numberOfGuests >= 10 && numberOfGuests <= 15)
            {
                pricePerMan -= pricePerMan * 0.15;
            }
            else if (numberOfGuests > 15 && numberOfGuests <= 20)
            {
                pricePerMan -= pricePerMan * 0.20;
            }
            else if (numberOfGuests > 20)
            {
                pricePerMan -= pricePerMan * 0.25;
            }

            double cake = desiSbudget * 0.10;
            double priceForAll = numberOfGuests * pricePerMan + cake;
            double totalPrice = Math.Abs(desiSbudget - priceForAll);

            if (desiSbudget >= priceForAll)
            {
                Console.WriteLine($"It is party time! {totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalPrice:f2} leva needed.");
            }



        }
    }
}
