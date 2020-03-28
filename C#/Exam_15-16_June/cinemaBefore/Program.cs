using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());

            string people = Console.ReadLine();
            int counter = 0;
            int entringPeople = 0;

            while (cinemaCapacity > entringPeople)
            {

                if (people == "Movie time!")
                {
                    break;
                }

                int checkPeople = int.Parse(people);

                if (checkPeople % 3 == 0 && checkPeople > 0)
                {
                    counter++;
                }
                entringPeople += int.Parse(people);

                if (entringPeople > cinemaCapacity)
                {
                    entringPeople = cinemaCapacity;
                    break;
                }
                people = Console.ReadLine();
            }

            int wholePrice = entringPeople * 5;
            int discount = counter * 5;

            if (people == "Movie time!")
            {
                Console.WriteLine($"There are {cinemaCapacity - entringPeople} seats left in the cinema.");
            }
            else if (entringPeople >= cinemaCapacity)
            {
                Console.WriteLine("The cinema is full.");

            }

            Console.WriteLine($"Cinema income - {wholePrice - discount} lv.");


        }
    }
}