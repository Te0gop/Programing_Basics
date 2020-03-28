using System;

namespace Switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Проверява променлива дали е равна на някаква стойност: а = 5 (т.е. при ==).
            // ако се проверяват числа кейса трябва да е число, а не стринг.

            string weather = Console.ReadLine();
            switch (weather)
            {
                case "sunny":
                    Console.WriteLine("Go outside!");
                    break;
                case "rainy":
                    Console.WriteLine("take an umbrella");
                    break;
                case "snowy":
                    Console.WriteLine("go skiing");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
