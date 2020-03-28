using System;

namespace filmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {

            string filmName = Console.ReadLine();
            string option = Console.ReadLine();
            int movieTicket = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (filmName == "John Wick")
            {
                if (option == "Drink")
                {
                    totalPrice += 12;
                }
                else if (option == "Popcorn")
                {
                    totalPrice += 15;
                }
                else if (option == "Menu")
                {
                    totalPrice += 19;
                }
                totalPrice *= movieTicket;
                Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
            }
            if (filmName == "Star Wars")
            {
                if (option == "Drink")
                {
                    totalPrice += 18;
                }
                else if (option == "Popcorn")
                {
                    totalPrice += 25;
                }
                else if (option == "Menu")
                {
                    totalPrice += 30;
                }
                if (movieTicket >= 4)
                {
                    totalPrice *= movieTicket;
                    totalPrice -= totalPrice * 0.3;
                    Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                }
                else
                {
                    totalPrice *= movieTicket;
                    Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                }
            }
            if (filmName == "Jumanji")
            {
                if (option == "Drink")
                {
                    totalPrice += 9;
                }
                else if (option == "Popcorn")
                {
                    totalPrice += 11;
                }
                else if (option == "Menu")
                {
                    totalPrice += 14;
                }
                if (movieTicket == 2)
                {
                    totalPrice *= movieTicket;
                    totalPrice -= totalPrice * 0.15;
                    Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                }
                else
                {
                    totalPrice *= movieTicket;
                    Console.WriteLine($"Your bill is {totalPrice:f2} leva.");
                }
            }





        }
    }
}
