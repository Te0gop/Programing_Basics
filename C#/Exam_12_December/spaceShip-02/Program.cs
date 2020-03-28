using System;

namespace spaceShip_02
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double averageHightAstronauts = double.Parse(Console.ReadLine());

            double roomsSpace = 2 * 2 * (averageHightAstronauts + 0.4);
            double spaceshipSize = width * lenght * hight;

            double astrounatsCount = Math.Floor(spaceshipSize / roomsSpace);


            if (astrounatsCount >= 3 && astrounatsCount <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astrounatsCount} astronauts.");
            }
            else if (astrounatsCount < 3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }


        }
    }
}
