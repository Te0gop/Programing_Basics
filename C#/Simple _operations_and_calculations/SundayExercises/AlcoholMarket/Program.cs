using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPriceBGN = double.Parse(Console.ReadLine());
            double beerQuantityLiters = double.Parse(Console.ReadLine());
            double wineQuantityLiters = double.Parse(Console.ReadLine());
            double rakiaQuantityLiters = double.Parse(Console.ReadLine());
            double whiskeyQuantityLiters = double.Parse(Console.ReadLine());
            double priceRakia = whiskeyPriceBGN / 2;
            double priceWine = priceRakia - (0.4 * priceRakia);
            double priceBeer = priceRakia - (0.8 * priceRakia);
            double priceWhiskey = whiskeyQuantityLiters * whiskeyPriceBGN;
            double priceForRakia = priceRakia * rakiaQuantityLiters;
            double priceForWine = priceWine * wineQuantityLiters;
            double PriceForBeer = priceBeer * beerQuantityLiters;
            double totalPrice = priceForRakia + priceForWine + PriceForBeer + priceWhiskey;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
