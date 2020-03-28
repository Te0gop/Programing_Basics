using System;

namespace bakingCompetition_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakersCount = int.Parse(Console.ReadLine());

            double totalCharitySum = 0;
            int totalCandiesSum = 0;

            for (int i = 0; i < bakersCount; i++)
            {

                string baker = Console.ReadLine();
                string candyType = Console.ReadLine();
                int cookiesCounter = 0;
                int cakesCounter = 0;
                int wafflesCounter = 0;
                double bakerBakedCandies = 0;


                while (candyType != "Stop baking!")
                {

                    int bakedCandies = int.Parse(Console.ReadLine());

                    switch (candyType)
                    {
                        case "cookies":
                            bakerBakedCandies += 1.50 * bakedCandies;
                            cookiesCounter += bakedCandies;
                            break;
                        case "cakes":
                            bakerBakedCandies += 7.80 * bakedCandies;
                            cakesCounter += bakedCandies;
                            break;
                        case "waffles":
                            bakerBakedCandies += 2.30 * bakedCandies;
                            wafflesCounter += bakedCandies;
                            break;
                    }

                    candyType = Console.ReadLine();

                }
                Console.WriteLine($"{baker} baked {cookiesCounter} cookies, {cakesCounter} cakes and {wafflesCounter} waffles.");
                totalCharitySum += bakerBakedCandies;
                totalCandiesSum += cookiesCounter + cakesCounter + wafflesCounter;

            }
            Console.WriteLine($"All bakery sold: {totalCandiesSum}");
            Console.WriteLine($"Total sum for charity: {totalCharitySum:F2} lv.");
        }
    }
}
