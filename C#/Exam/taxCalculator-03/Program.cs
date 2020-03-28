using System;

namespace taxCalculator_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int enginePower = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            string ekoStandart = Console.ReadLine();

            double totalPrice = 0;

            if (enginePower <= 37)
            {
                if (city == "Sofia")
                {
                    totalPrice += enginePower * 1.43;
                }
                else if (city == "Vidin")
                {
                    totalPrice += enginePower * 1.34;
                }
                else if (city == "Varna")
                {
                    totalPrice += enginePower * 1.37;
                }

            }
            else if (enginePower >= 38 && enginePower <= 55)
            {
                if (city == "Sofia")
                {
                    totalPrice += enginePower * 1.50;
                }
                else if (city == "Vidin")
                {
                    totalPrice += enginePower * 1.40;
                }
                else if (city == "Varna")
                {
                    totalPrice += enginePower * 1.40;
                }

            }
            else if (enginePower > 55)
            {
                if (city == "Sofia")
                {
                    totalPrice += enginePower * 2.68;
                }
                else if (city == "Vidin")
                {
                    totalPrice += enginePower * 2.54;
                }
                else if (city == "Varna")
                {
                    totalPrice += enginePower * 2.57;
                }

            }
            
            if (ekoStandart == "Euro 4")
            {
                totalPrice *= 0.85;
            }
            else if (ekoStandart == "Euro 5")
            {
                totalPrice *= 0.83;
            }
            else if (ekoStandart == "Euro 6")
            {
                totalPrice *= 0.80;
            }

            Console.WriteLine($"{totalPrice:F2} lv");

        }
    }
}
