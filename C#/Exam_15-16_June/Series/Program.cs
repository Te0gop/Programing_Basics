using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfSeries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSeries; i++)
            {
                string seriesName = Console.ReadLine();
                double priceForOneSerial = double.Parse(Console.ReadLine());

                if (seriesName == "Thrones")
                {
                    budget -= priceForOneSerial - (priceForOneSerial * 0.50);
                }
                else if (seriesName == "Lucifer")
                {
                    budget -= priceForOneSerial - (priceForOneSerial * 0.40);

                }
                else if (seriesName == "Protector")
                {
                    budget -= priceForOneSerial - (priceForOneSerial * 0.30);
                }
                else if (seriesName == "TotalDrama")
                {
                    budget -= priceForOneSerial - (priceForOneSerial * 0.20);
                }
                else if (seriesName == "Area")
                {
                    budget -= priceForOneSerial - (priceForOneSerial * 0.10);
                }
                else
                {
                    budget -= priceForOneSerial;
                }
                
            }
            if (budget >= 0)
            {
                Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");
            }
        }
    }
}
