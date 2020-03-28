using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());

            string people = Console.ReadLine();
            double profit = 0;
            bool fullCinema = false;

            while (people != "Movie time!")
            {
                int checkPeople = int.Parse(people);
                cinemaCapacity -= checkPeople;

                if (0 > cinemaCapacity)
                {
                    Console.WriteLine("The cinema is full.");
                    fullCinema = true;
                    break;
                }

                if (checkPeople % 3 == 0)
                {
                    profit += (checkPeople * 5 - 5);
                }
                else
                {
                    profit += checkPeople * 5;
                }                

                people = Console.ReadLine();
            }

            if (!fullCinema)
            {
                Console.WriteLine($"There are {cinemaCapacity} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {profit} lv.");


        }
    }
}