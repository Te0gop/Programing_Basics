using System;

namespace biggestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bigNum = 0;
            int max = -1000000000;
            
            while (bigNum < number)
            {
                int bigger = int.Parse(Console.ReadLine());
                if (bigger > max)
                {
                    max = bigger;
                }
               
                bigNum++;
            }
            Console.WriteLine(max);
        }
    }
}
