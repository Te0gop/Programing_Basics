using System;

namespace bachelorParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int performCost = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int totalGuests = 0;
            int income = 0;

            while(input != "The restaurant is full")
            {
                int currentGuests = int.Parse(input);
                totalGuests += currentGuests;

                if (currentGuests >= 5)
                {
                    income += currentGuests * 70;
                }
                else
                {
                    income += currentGuests * 100;
                }

                input = Console.ReadLine();
            }
            if (income >= performCost)
            {
                int diff = income - performCost;
                Console.WriteLine($"You have {totalGuests} guests and {diff} leva left.");
            }
            else
            {
                Console.WriteLine($"You have {totalGuests} guests and {income} leva income, but no singer.");
            }
        }
    }
}
