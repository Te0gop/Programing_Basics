using System;

namespace Time_15min_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;

            if (minutes >= 45 && hours < 23)
            {
                minutes += 15 - 60;
                hours += 1;
            }
            else if (minutes >= 45 && hours == 23)
            {
                minutes += 15 - 60;
                hours = 0;
            }
            else
            {
                minutes += 15;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
