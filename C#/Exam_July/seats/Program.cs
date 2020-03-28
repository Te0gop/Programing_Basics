using System;

namespace seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int tickets = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < tickets; i++)
            {
                string ticketsName = Console.ReadLine();
                char input = ticketsName[0];
                
                if (ticketsName.Length == 4)
                {
                    if (input >= 'A' && input <= 'Z')
                    {
                        result += ticketsName[0];
                        result += ticketsName[1];
                        result += ticketsName[2];
                    }
                    else
                    {
                        result += ticketsName[3];
                        result += ticketsName[1];
                        result += ticketsName[2];

                    }

                }
                if (ticketsName.Length >= 5)
                {
                    result += ticketsName[0];
                    result += (int)ticketsName[1];
                }

                Console.WriteLine($"Seat decoded: {result}");
                result = string.Empty;
            }
        }
    }
}
