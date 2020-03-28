using System;

namespace exampleVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string result = firstName + lastName + "@" + age + "-years old.";
            Console.WriteLine(result);
            
        }
    }
}
