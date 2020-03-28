using System;

namespace inches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
