using System;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int h = hours;
            int m = (minutes % 60) + 15;
            Console.WriteLine(minutes % 60);
            if (m > 59)
            {
                h += 1;
                m -= 60;
            }
            if (h > 23)
            {
                h = 0;
            }
            if (m < 10)
            {
                Console.WriteLine(h + ":0" + m);
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }

        }
    }
}
