using System;

namespace firstname
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = Console.ReadLine();
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {2}, {3}-years old from {3}", firstname, lastName, age, town);

        }
    }
}
