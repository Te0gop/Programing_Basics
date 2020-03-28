using System;

namespace backToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int ivanchosAge = 18;
            double spendMoney = 0;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    spendMoney = 12000;
                    money -= spendMoney;
                }
                else if (i % 2 == 1)
                {
                    spendMoney = 12000 + 50 * ivanchosAge;
                    money -= spendMoney;
                }

                ivanchosAge++;
            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
