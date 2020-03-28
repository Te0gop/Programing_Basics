using System;

namespace vacationJessy
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int totalDays = 0;

            while (savedMoney < moneyNeeded)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                totalDays++;

                if (action == "spend")
                {
                    spendCounter++;
                    if (spendCounter == 5)
                    {
                        break;
                    }
                        
                    if (money > savedMoney)
                    {
                        savedMoney = 0;
                    }
                    else
                    {
                        savedMoney -= money;
                    }
                    
                }
                else if (action == "save")
                {
                    spendCounter = 0;
                    savedMoney += money;
                }

            }
            if (spendCounter == 5)
            {
                
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            if (savedMoney >= moneyNeeded)
            { 
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}