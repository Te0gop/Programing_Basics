using System;

namespace cruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruise = Console.ReadLine();
            string cabin = Console.ReadLine();
            int overnights = int.Parse(Console.ReadLine());
            double price = 0;


            if (cruise == "Mediterranean")
            {
                if (cabin == "standard cabin")
                {
                    price = 27.50;

                }
                else if (cabin == "cabin with balcony")
                {
                    price = 30.20;
                }
                else if (cabin == "apartment")
                {
                    price = 40.50;
                }

            }

            else if (cruise == "Adriatic")
            {
                if (cabin == "standard cabin")
                {
                    price = 22.99;

                }
                else if (cabin == "cabin with balcony")
                {
                    price = 25.00;
                }
                else if (cabin == "apartment")
                {
                    price = 34.99;
                }

            }
            else if (cruise == "Aegean")
            {
                if (cabin == "standard cabin")
                {
                    price = 23.00;

                }
                else if (cabin == "cabin with balcony")
                {
                    price = 26.60;
                }
                else if (cabin == "apartment")
                {
                    price = 39.80;
                }

            }
            if (overnights > 7)
            {
                double trip = price * overnights * 4;
                double discount = trip * 0.25;
                trip -= discount;
                Console.WriteLine($"Annie's holiday in the {cruise} sea costs {trip:f2} lv.");
            }
            else
            {
                double trip = price * overnights * 4;
                Console.WriteLine($"Annie's holiday in the {cruise} sea costs {trip:f2} lv.");

            }


        }
    }
}
