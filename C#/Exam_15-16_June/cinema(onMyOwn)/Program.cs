using System;

namespace cinema_onMyOwn_
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int totalPrice = 0;
            int price = 0;
            bool fullCinema = false;

            while (input != "Movie time!")
            {
                int seats = int.Parse(input);

                if (seats % 3 == 0)
                {
                    price = seats * 5 - 5;
                    totalPrice += price;
                }
                else
                {
                    price = seats * 5;
                    totalPrice += price;
                }

                hallCapacity -= seats;

                if (hallCapacity < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    totalPrice -= price;
                    fullCinema = true;
                    break;
                }

                input = Console.ReadLine();
            }
            if (!fullCinema)
            {
                Console.WriteLine($"There are {hallCapacity} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {totalPrice} lv.");
        }
    }
}
