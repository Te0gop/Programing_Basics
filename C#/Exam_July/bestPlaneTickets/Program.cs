using System;

namespace bestPlaneTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            
            double minDelay = 1000000000;
            double minPriceOfTicket = 0;
            string flightName = string.Empty;


            while (ticket != "End")
            {
                double priceOfTicket = double.Parse(Console.ReadLine()) * 1.96;
                double minutesDelay = double.Parse(Console.ReadLine());
               

                if (minutesDelay < minDelay)
                {
                    minDelay = minutesDelay;
                    flightName = ticket;
                    minPriceOfTicket = priceOfTicket;
                   
                }
                ticket = Console.ReadLine();
            }
            double hours = Math.Floor(minDelay / 60);
            double minutes = minDelay % 60;
            Console.WriteLine($"Ticket found for flight {flightName} costs {minPriceOfTicket:f2} leva with {hours}h {minutes}m stay");


        }
    }
}
