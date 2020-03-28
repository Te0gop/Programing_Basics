using System;

namespace WeatherForecast_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = double.Parse(Console.ReadLine());
            if (temp > 35.00)
            {
                Console.WriteLine("unknown");
            }
            else if (temp >= 26.00)
            {
                Console.WriteLine("Hot");
            }
            else if (temp >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (temp >= 15.00)
            {
                Console.WriteLine("Mild");
            }
            else if (temp >= 12.00)
            {
                Console.WriteLine("Cool");
            }
            else if (temp >= 5.00)
            {
                Console.WriteLine("Cold");
            }
            else if (temp <= 4.9)
            {
                Console.WriteLine("unknown");
            }     

        }
    }
}
