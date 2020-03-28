using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            while (input != "stop")
            {
                sum += int.Parse(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
    }
}
