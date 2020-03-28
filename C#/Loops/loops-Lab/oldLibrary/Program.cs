using System;

namespace oldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int libraryVolume = int.Parse(Console.ReadLine());

            int counter = 0;

            while (libraryVolume > counter)
            {

                string bookString = Console.ReadLine();

                if (bookName == bookString)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }

                counter++;
            }

            if (libraryVolume <= counter)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }

        }
    }
}
