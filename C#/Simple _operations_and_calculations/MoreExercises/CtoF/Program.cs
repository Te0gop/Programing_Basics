using System;

namespace CtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double farenhait = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{farenhait:F2}");
        }
    }
}
