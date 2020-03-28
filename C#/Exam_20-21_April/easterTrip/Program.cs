using System;

namespace easterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int overnights = int.Parse(Console.ReadLine());

            int totalPrice = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    totalPrice += 30 * overnights;
                }
                else if (dates == "24-27")
                {
                    totalPrice += 35 * overnights;
                }
                else if (dates == "28-31")
                {
                    totalPrice += 40 * overnights;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    totalPrice += 28 * overnights;
                }
                else if (dates == "24-27")
                {
                    totalPrice += 32 * overnights;
                }
                else if (dates == "28-31")
                {
                    totalPrice += 39 * overnights;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    totalPrice += 32 * overnights;
                }
                else if (dates == "24-27")
                {
                    totalPrice += 37 * overnights;
                }
                else if (dates == "28-31")
                {
                    totalPrice += 43 * overnights;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");

        }
    }
}
