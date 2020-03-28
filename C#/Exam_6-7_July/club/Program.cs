using System;

namespace club
{
    class Program
    {
        static void Main(string[] args)
        {
            double wantedProfit = double.Parse(Console.ReadLine());
            string coctailName = Console.ReadLine();
            double income = 0.0;

            while (coctailName != "Party!")
            {
                int numOfCoctails = int.Parse(Console.ReadLine());
                int price = numOfCoctails * coctailName.Length;
                double finalPrice = price;

                if (price % 2 != 0)
                {
                    finalPrice *= 0.75;
                }
                income += finalPrice;
                wantedProfit -= finalPrice;
                if (wantedProfit <= 0)
                {
                    break;
                }

                coctailName = Console.ReadLine();
            }
            if (coctailName == "Party!")
            {
                Console.WriteLine($"We need {wantedProfit:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {income:F2} leva.");


        }
    }
}
