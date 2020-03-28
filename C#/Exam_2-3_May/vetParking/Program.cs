using System;

namespace vetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int hoursOfParking = int.Parse(Console.ReadLine());

            double wholeSum = 0;
            int day = 0;

            for (int i = 0; i < numberOfDays; i++)
            {
                day++;
                int hours = 0;
                double pricePerDay = 0;

                for (int g = 0; g < hoursOfParking; g++)
                {
                    hours++;

                    if (day % 2 == 0 && hours % 2 == 1)
                    {
                        pricePerDay += 2.50;
                    }
                    else if (day % 2 == 1 && hours % 2 == 0)
                    {
                        pricePerDay += 1.25;
                    }
                    else
                    {
                        pricePerDay += 1.00;
                    }
                }
                wholeSum += pricePerDay;
                Console.WriteLine($"Day: {day} - {pricePerDay:f2} leva");
            }
            Console.WriteLine($"Total: {wholeSum:f2} leva");
        }
    }
}
