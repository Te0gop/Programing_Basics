﻿using System;

namespace GreatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else if (numTwo > numOne)
            {
                Console.WriteLine(numTwo);
            }
            else
            {
                Console.WriteLine("They're equal.");
            }
        }
    }
}
