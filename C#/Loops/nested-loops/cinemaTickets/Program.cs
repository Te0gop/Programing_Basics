using System;

namespace cinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            string movieName = Console.ReadLine();

            int standartTicketCount = 0;
            int studentTicketCount = 0;
            int kidTicketCount = 0;
            int totalTicketCount = 0;

            while (movieName != "Finish")
            {

                int seatCount = int.Parse(Console.ReadLine());
                int ticketCount = 0;

                for (int i = 0; i < seatCount; i++)
                {
                    string ticketType = Console.ReadLine();
                    
                    switch (ticketType)
                    {
                        case "standard":
                            standartTicketCount++;
                            ticketCount++;
                            break;
                        case "student":
                            studentTicketCount++;
                            ticketCount++;
                            break;
                        case "kid":
                            kidTicketCount++;
                            ticketCount++;
                            break;
                        


                    }
                    if (ticketType == "End")
                    {
                        break;
                    }

                }
                double percentFilled = ((double)ticketCount / seatCount) * 100;
                Console.WriteLine($"{movieName} - {percentFilled:F2}% full.");
                totalTicketCount += ticketCount;
                movieName = Console.ReadLine();
            }
            double studentTicketPercent = (double)studentTicketCount / totalTicketCount * 100;
            double standartTicketPercent = (double)standartTicketCount / totalTicketCount * 100;
            double kidTicketPercent = (double)kidTicketCount / totalTicketCount * 100;

            Console.WriteLine($"Total tickets: {totalTicketCount}");
            Console.WriteLine($"{studentTicketPercent:F2}% student tickets.");
            Console.WriteLine($"{standartTicketPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidTicketPercent:F2}% kids tickets.");
        }
    }
}
