using System;

namespace bus_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int stops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stops; i++)
            {
                int passengersLeft = int.Parse(Console.ReadLine());
                int passengersIn = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    passengers += 2;
                    passengers += passengersIn;
                    passengers -= passengersLeft;
                }
                else
                {
                    passengers += passengersIn;
                    passengers -= 2;
                    passengers -= passengersLeft;
                }

            }
            Console.WriteLine($"The final number of passengers is : {passengers}");

        }
    }
}
