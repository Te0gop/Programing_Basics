using System;

namespace easterBakery_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourKGs = double.Parse(Console.ReadLine());
            double sugarKGs = double.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int bakerPowder = int.Parse(Console.ReadLine());

            double sugarPrice = flourPrice * 0.75;
            double eggsPrice = flourPrice * 1.1;
            double bakerPowderPrice = sugarPrice * 0.20;

            double totalPrice = flourPrice * flourKGs + sugarKGs * sugarPrice + eggs * eggsPrice + bakerPowder * bakerPowderPrice;
            Console.WriteLine($"{totalPrice:f2}");



        }
    }
}
