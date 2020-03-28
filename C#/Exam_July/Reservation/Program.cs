using System;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayReservation = int.Parse(Console.ReadLine());
            int monthReservation = int.Parse(Console.ReadLine());
            int daySettle = int.Parse(Console.ReadLine());
            int monthSettle = int.Parse(Console.ReadLine());
            int dayLeave = int.Parse(Console.ReadLine());
            int monthLeave = int.Parse(Console.ReadLine());
            int priceDis = (dayLeave - daySettle);

            double priceOneNight = 0;
            double reservation = priceDis * priceOneNight;

            if (priceDis >= 10)
            {
                priceOneNight = 25;
                reservation = priceDis * priceOneNight;
            }
            else
            {
                priceOneNight = 30;
                reservation = priceDis * priceOneNight;
            }

            if (monthReservation != monthLeave)
            {
                priceOneNight = 25;
                reservation = priceDis * priceOneNight;
                double dis = reservation * 0.2;
                reservation -= dis;
                

            }
            Console.WriteLine($"Your stay from {daySettle}/{monthSettle} to {dayLeave}/{monthLeave} will cost {reservation:f2}");



        }
    }
}
