using System;

namespace BonusScore_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // && - and
            // || - or
            // ! - negation (razlichno)

            int num = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (num <= 100)
            {
                bonusPoints = 5;
            }
            else if (num <= 1000)
            {
                bonusPoints = num * 0.2;
            }
            else if (num > 1000)
            {
                bonusPoints = num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (num % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(num + bonusPoints);
        }
    }
}
