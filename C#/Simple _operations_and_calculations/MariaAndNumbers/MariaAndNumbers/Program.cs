using System;

namespace MariaAndNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 6;
            var c = 12;
            var sum = " * : " + (a * b * c);
            Console.WriteLine(sum);
            var firstName = "Maria ";
            var lastName = "Ivanova ";
            var age = "24";
            var str = firstName + lastName + "is at " + age;
            Console.WriteLine(str);
          
        }
    }
}
