using System;

namespace luggageTax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();

            int volume = width * height * depth;
            int tax = 0;


            if (ticket == "true")
            {
                if (volume > 50 && volume <= 100)
                {
                    tax = 0;
                }
                else if (volume > 100 && volume <= 200)
                {
                    tax = 10;
                }
                else if (volume > 200 && volume <= 300)
                {
                    tax = 20;
                }
            }
            else 
            {
                if (volume > 50 && volume <= 100)
                {
                    tax = 25;
                }
                else if (volume > 100 && volume <= 200)
                {
                    tax = 50;
                }
                else if (volume > 200 && volume <= 300)
                {
                    tax = 100;
                }
                
            }

            Console.WriteLine($"Luggage tax: {tax:f2}");

        }
    }
}
