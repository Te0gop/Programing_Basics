using System;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double petersBudget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoPrice = videocards * 250;
            double procPrice = (videoPrice * 0.35) * processors;
            double ramPrice = (videoPrice * 0.10) * ram;

            double totalPrice = videoPrice + procPrice + ramPrice;
            if (videocards > processors)
            {
                totalPrice -= totalPrice * 0.15;
            }

            if (petersBudget >= totalPrice)
            {
                Console.WriteLine($"You have {petersBudget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - petersBudget:f2} leva more!");
            }

        }
    }
}
