using System;

namespace logistics_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int goods = int.Parse(Console.ReadLine());

            int bus = 0;
            int truck = 0;
            int train = 0;
            int goodsWeightSum = 0;
            double price = 0;

            for (int i = 0; i < goods; i++)
            {
                int goodsWeight = int.Parse(Console.ReadLine());
                goodsWeightSum += goodsWeight;

                if (goodsWeight <= 3)
                {
                    bus += goodsWeight;
                    price += goodsWeight * 200;

                }
                else if (goodsWeight >= 4 && 11 >= goodsWeight)
                {
                    truck += goodsWeight;
                    price += goodsWeight * 175;
                }
                else if (goodsWeight >= 12)
                {
                    train += goodsWeight;
                    price += goodsWeight * 120;

                }

            }
            double averagePrice = price / goodsWeightSum;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{(bus * 1.0 / goodsWeightSum * 100):f2}%");
            Console.WriteLine($"{(truck * 1.0 / goodsWeightSum * 100):f2}%");
            Console.WriteLine($"{(train * 1.0 / goodsWeightSum * 100):f2}%");
        }
    }
}
