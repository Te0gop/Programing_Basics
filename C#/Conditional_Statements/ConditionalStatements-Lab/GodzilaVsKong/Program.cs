using System;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int statistsNum = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            double filmsDecor = filmBudget * 0.1;
            double statistClothes = statistsNum * clothesPrice;

            double discount = 0;
            
            if (statistsNum > 150)
            {
                discount = statistClothes * 0.1;
                statistClothes -= discount;
            }
            else
            {
                discount = 0;
            }

            if ((filmsDecor + statistClothes) > filmBudget )
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(filmsDecor+statistClothes)-filmBudget:f2} leva more.");

            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - (filmsDecor + statistClothes):F2} leva left.");

            }

     


        }
    }
}
