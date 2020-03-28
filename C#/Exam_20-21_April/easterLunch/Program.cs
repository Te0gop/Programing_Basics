using System;

namespace easterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            double eggsPrice = eggs * 4.35;
            double eggsPaint = eggs * 12 * 0.15;
            double breadPrice = easterBread * 3.20;
            double cookiesPrice = cookies * 5.40;

            double totalPrice = eggsPrice + breadPrice + cookiesPrice + eggsPaint;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
