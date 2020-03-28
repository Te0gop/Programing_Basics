using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double s = tables * (lenght + 2 * 0.30) * (width + 2 * 0.30);
            double s1 = tables * (lenght / 2) * (lenght / 2);
            double priceUSD = (s * 7) + (s1 * 9);
            double priceBGN = (priceUSD * 1.85);
            Console.WriteLine($"{priceUSD:f2} USD");
            Console.WriteLine($"{priceBGN:F2} BGN");

        }
    }
}
