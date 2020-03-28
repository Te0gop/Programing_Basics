using System;

namespace snookerChampionship_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            string photo = Console.ReadLine();

            double ticketPrice = 0;

            if (ticketType == "Standard")
            {
                if (stage == "Quarter final")
                {
                    ticketPrice = 55.5;
                }
                else if (stage == "Semi final")
                {
                    ticketPrice = 75.8;

                }
                else if (stage == "Final")
                {
                    ticketPrice = 110.1;
                }
            }
            else if (ticketType == "Premium")
            {
                if (stage == "Quarter final")
                {
                    ticketPrice = 105.2;
                }
                else if (stage == "Semi final")
                {
                    ticketPrice = 125.22;
                }
                else if (stage == "Final")
                {
                    ticketPrice = 160.66;
                }

            }
            else if (ticketType == "VIP")
            {
                if (stage == "Quarter final")
                {
                    ticketPrice = 118.9;
                }
                else if (stage == "Semi final")
                {
                    ticketPrice = 300.4;
                }
                else if (stage == "Final")
                {
                    ticketPrice = 400.0;
                }

            }
            double totalPrice = ticketPrice * ticketCount;

            if (totalPrice > 2500 && totalPrice <= 4000)
            {
                totalPrice -= totalPrice * 0.10;

            }
            else if (totalPrice > 4000)
            {
                totalPrice -= totalPrice * 0.25;
            }

            if (photo == "Y" && totalPrice <= 4000)
            {
                totalPrice += 40 * ticketCount;
            }



            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}