using System;

namespace SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double durationEpisode = double.Parse(Console.ReadLine());

            double advertisings = durationEpisode * 0.20;
            durationEpisode += advertisings;
            int specialEpisodes = seasons * 10;
            double durationPerSeason = durationEpisode * episodes;
            double time = Math.Floor(durationPerSeason * seasons + specialEpisodes);

            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {time} minutes.");


        }
    }
}
