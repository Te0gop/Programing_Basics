using System;

namespace eggsPainting_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int batches = int.Parse(Console.ReadLine());

            int totalPrice = 0;

            if (eggsSize == "Large")
            {
                switch (eggsColor)
                {
                    case "Red":
                        totalPrice += batches * 16;
                        break;
                    case "Green":
                        totalPrice += batches * 12;
                        break;
                    case "Yellow":
                        totalPrice += batches * 9;
                        break;
                }
            }
            else if (eggsSize == "Medium")
            {
                switch (eggsColor)
                {
                    case "Red":
                        totalPrice += batches * 13;
                        break;
                    case "Green":
                        totalPrice += batches * 9;
                        break;
                    case "Yellow":
                        totalPrice += batches * 7;
                        break;
                }
            }
            else if (eggsSize == "Small")
            {
                switch (eggsColor)
                {
                    case "Red":
                        totalPrice += batches * 9;
                        break;
                    case "Green":
                        totalPrice += batches * 8;
                        break;
                    case "Yellow":
                        totalPrice += batches * 5;
                        break;
                }
            }

            double productionCosts = totalPrice * 0.35;
            Console.WriteLine($"{totalPrice-productionCosts:f2} leva.");

        }
    }
}
