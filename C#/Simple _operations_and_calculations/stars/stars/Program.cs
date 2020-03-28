using System;

namespace stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n - 2; i++);
            Console.WriteLine("*{0}*", new string(' ', n - 2));

        }
    }
}
