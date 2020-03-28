using System;

namespace poolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double deckChairPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double entranceTax = people * tax;
            double umbrellasNum = Math.Ceiling(people / 2);
            double deckChairNum = Math.Ceiling(people * 0.75);
            double umbrellasSum = umbrellaPrice * umbrellasNum;
            double deckChairSum = deckChairPrice * deckChairNum;

            double price = entranceTax + umbrellasSum + deckChairSum;

            Console.WriteLine($"{price:f2} lv.");



        }
    }
}
