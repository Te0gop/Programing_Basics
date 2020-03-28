using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            double dogsHood = double.Parse(Console.ReadLine());
            double sumDogsFood = dogsFood * 2.5;
            double sumDogsHood = dogsHood * 4;
            double result = sumDogsFood + sumDogsHood;
            Console.WriteLine("{0:F2} lv." , result);
        }
    }
}
