using System;

namespace coffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfdrinks = int.Parse(Console.ReadLine());

            double priceForDrinks = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    priceForDrinks += 0.90 * numberOfdrinks;
                }
                else if (sugar == "Normal")
                {
                    priceForDrinks += 1.00 * numberOfdrinks;
                }
                else if (sugar == "Extra")
                {
                    priceForDrinks += 1.20 * numberOfdrinks;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    priceForDrinks += 1.00 * numberOfdrinks;
                }
                else if (sugar == "Normal")
                {
                    priceForDrinks += 1.20 * numberOfdrinks;
                }
                else if (sugar == "Extra")
                {
                    priceForDrinks += 1.60 * numberOfdrinks;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    priceForDrinks += 0.50 * numberOfdrinks;
                }
                else if (sugar == "Normal")
                {
                    priceForDrinks += 0.60 * numberOfdrinks;
                }
                else if (sugar == "Extra")
                {
                    priceForDrinks += 0.70 * numberOfdrinks;
                }

            }            
            if (sugar == "Without")
            {
                priceForDrinks -= priceForDrinks * 0.35;
                
            }
            if (drink == "Espresso" && numberOfdrinks >= 5)
            {
                priceForDrinks -= priceForDrinks * 0.25;
            }
            if (priceForDrinks > 15)
            {
                priceForDrinks -= priceForDrinks * 0.20;
            }

            Console.WriteLine($"You bought {numberOfdrinks} cups of {drink} for {priceForDrinks:f2} lv.");

        }


    }
}
