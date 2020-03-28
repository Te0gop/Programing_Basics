using System;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double roomForOne = 18;
            double apartment = 25;
            double presidentApartment = 35;
            double price = 0;
            double discount = 0;
            days = days - 1;

            if (room == "room for one person")
            {
                if (days < 10 || days > 10)
                {
                    price = roomForOne * days;
                }
            }

            if (room == "apartment")
            {
                if (days < 10)
                {
                    price = apartment * days;
                    discount = price * 0.30;
                    price = price - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = apartment * days;
                    discount = price * 0.35;
                    price = price - discount;

                }
                else if (days > 15)
                {
                    price = apartment * days;
                    discount = price * 0.50;
                    price = price - discount;

                }

            }
            if (room == "president apartment")
            {
                if (days < 10)
                {
                    price = presidentApartment * days;
                    discount = price * 0.10;
                    price = price - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    price = presidentApartment * days;
                    discount = price * 0.15;
                    price = price - discount;

                }
                else if (days > 15)
                {
                    price = presidentApartment * days;
                    discount = price * 0.20;
                    price = price - discount;
                }
                
            }
            if (rating == "positive")
            {
                price = price + (price * 0.25);

                Console.WriteLine($"{price:f2}");
            }
            else if (rating == "negative")
            {
                price = price - (price * 0.10);
                Console.WriteLine($"{price:f2}");
            }

        } 

    }
}