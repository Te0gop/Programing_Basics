using System;

namespace square
{
    class Program
    {
        static void Main()
        {
            Console.Write("a =  ");
            var a = double.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square area =  ");
            Console.WriteLine(area);
        }
    }
}
