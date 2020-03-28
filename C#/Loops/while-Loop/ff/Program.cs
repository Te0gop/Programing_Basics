using System;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());

            double changeSt = Math.Round(coins * 100);
            int counter = 0;

            while (changeSt > 0)
            {

                if (changeSt >= 200)
                {
                    counter++;
                    changeSt -= 200;
                }
                else if (changeSt >= 100)
                {
                    counter++;
                    changeSt -= 100;
                }
                else if (changeSt >= 50)
                {
                    counter++;
                    changeSt -= 50;
                }
                else if (changeSt >= 20)
                {
                    counter++;
                    changeSt -= 20;
                }
                else if (changeSt >= 10)
                {
                    counter++;
                    changeSt -= 10;
                }
                else if (changeSt >= 5)
                {
                    counter++;
                    changeSt -= 5;
                }
                else if (changeSt >= 2)
                {
                    counter++;
                    changeSt -= 2;
                }
                else if (changeSt >= 1)
                {
                    counter++;
                    changeSt -= 1;
                }
                else if (changeSt == 0)
                {
                    break;
                }

            }
            Console.WriteLine(counter);

        }
    }
}
