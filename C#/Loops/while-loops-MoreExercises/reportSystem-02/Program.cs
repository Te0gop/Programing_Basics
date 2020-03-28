using System;

namespace reportSystem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int charitySum = int.Parse(Console.ReadLine());

            double cashPayment = 0;
            double creditCardPayment = 0;
            int counter = 0;
            int cashCounter = 0;
            int creditCardCounter = 0;
            bool noCharity = false;

            string price = Console.ReadLine();

            while (price != "End")
            {
                int productsPrice = int.Parse(price);
                counter++;

                if (counter % 2 == 1 && productsPrice <= 100)
                {
                    cashPayment += productsPrice;
                    cashCounter++;
                    charitySum -= productsPrice;
                    Console.WriteLine("Product sold!");
                }
                else if (counter % 2 == 0 && productsPrice >= 10)
                {
                    creditCardPayment += productsPrice;
                    creditCardCounter++;
                    charitySum -= productsPrice;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                }
                if (charitySum <= 0)
                {
                    Console.WriteLine($"Average CS: {cashPayment / cashCounter:F2}");
                    Console.WriteLine($"Average CC: {creditCardPayment / creditCardCounter:F2}");
                    noCharity = true;
                    break;
                }
                price = Console.ReadLine();
            }
            if (!noCharity)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
