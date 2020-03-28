using System;

namespace lunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int durationEpisode = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());

            double lunch = durationBreak / 8.0;
            double breakAfterLunch = durationBreak / 4.0;
            double time = durationBreak - lunch - breakAfterLunch;
            double finalTime = Math.Abs (durationEpisode - time);

            if (time >= durationEpisode)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(finalTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(finalTime)} more minutes.");
            }

        }
    }
}
