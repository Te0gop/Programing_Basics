using System;

namespace tradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double percent = 0;


            if (sells < 0)
            {
                Console.WriteLine("error");
            }

            else if (city == "Sofia")
            {
                if (sells >= 0 && sells <= 500)
                {
                    percent = 5 * sells / 100;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    percent = 7 * sells / 100;
                }
                else if (sells >= 1000 && sells <= 10000)
                {
                    percent = 8 * sells / 100;
                }
                else if (sells > 10000)
                {
                    percent = 12 * sells / 100;
                }
                Console.WriteLine($"{percent:f2}");
            }
            else if (city == "Varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    percent = 4.5 * sells / 100;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    percent = 7.5 * sells / 100;
                }
                else if (sells >= 1000 && sells <= 10000)
                {
                    percent = 10 * sells / 100;
                }
                else if (sells > 10000)
                {
                    percent = 13 * sells / 100;
                }
                Console.WriteLine($"{percent:f2}");
            }
            else if (city == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    percent = 5.5 * sells / 100;
                }
                else if (sells > 500 && sells <= 1000)
                {
                    percent = 8 * sells / 100;
                }
                else if (sells >= 1000 && sells <= 10000)
                {
                    percent = 12 * sells / 100;
                }
                else if (sells > 10000)
                {
                    percent = 14.5 * sells / 100;
                }
                Console.WriteLine($"{percent:f2}");
            }
            else if (city == "Plovdiv" || city == "Varna" || city == "Sofia" || sells < 0 || sells > 0)
            {
                Console.WriteLine("error");
            }
            else if (city == "Plovdiv" || city == "Varna" || city == "Sofia" && sells > 0)
            {

            }

        }

    }
}