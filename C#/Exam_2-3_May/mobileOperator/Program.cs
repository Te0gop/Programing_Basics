using System;

namespace mobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string termContract = Console.ReadLine();
            string contractType = Console.ReadLine();
            string mobileNet = Console.ReadLine();
            int monthsOfPayment = int.Parse(Console.ReadLine());

            double sum = 0;

            if (termContract == "one")
            {
                switch (contractType)
                {
                    case "Small":
                        sum += 9.98;
                        break;
                    case "Middle":
                        sum += 18.99;
                        break;
                    case "Large":
                        sum += 25.98;
                        break;
                    case "ExtraLarge":
                        sum += 35.99;
                        break;
                }
            }
            else if (termContract == "two")
            {
                switch (contractType)
                {
                    case "Small":
                        sum += 8.58;
                        break;
                    case "Middle":
                        sum += 17.09;
                        break;
                    case "Large":
                        sum += 23.59;
                        break;
                    case "ExtraLarge":
                        sum += 31.79;
                        break;
                }
            }
            if (mobileNet == "yes")
            {
                if (sum <= 10)
                {
                    sum += 5.50;
                }
                else if (sum <= 30)
                {
                    sum += 4.35;
                }
                else if (sum > 30)
                {
                    sum += 3.85;
                }
            }

            sum *= monthsOfPayment;

            if (termContract == "two")
            {
                sum -= sum * 0.0375;
            }

            Console.WriteLine($"{sum:f2} lv.");

        }
    }
}
