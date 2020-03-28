using System;

namespace cleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double totalPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double savings = 0;
            double moneyPresent = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyPresent += 10;
                    savings += moneyPresent;
                    savings -= 1;
                }
                else
                {
                    savings += toyPrice;
                }

            }
            if (savings >= totalPrice)
            {
                Console.WriteLine($"Yes! {savings - totalPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {totalPrice - savings:f2}");
            }

        }
    }
}
