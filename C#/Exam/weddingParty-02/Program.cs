using System;

namespace weddingParty_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cuvertPricce = numberOfGuests * 20.0;

            if (cuvertPricce <= budget)
            {
                double leftMoney = budget - cuvertPricce;
                double percentMoney = leftMoney * 0.40;
                double flamesMoney = leftMoney - percentMoney;
                Console.WriteLine($"Yes! {Math.Round(percentMoney)} lv are for fireworks and {Math.Round(flamesMoney)} lv are for donation.");
            }
            else
            {
                double diff = cuvertPricce - budget;
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(diff)} lv more.");
            }

        }
    }
}
