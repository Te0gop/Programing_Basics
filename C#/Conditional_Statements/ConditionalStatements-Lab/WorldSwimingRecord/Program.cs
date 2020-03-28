using System;

namespace WorldSwimingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceM = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double totalSeconds = distanceM * secondsPerMeter;
            double delay = Math.Floor(distanceM / 15) * 12.5;
            totalSeconds += delay;
            
           
            if (totalSeconds < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:f2} seconds.");
            }
            else if (totalSeconds >= record)
            {

                Console.WriteLine($"No, he failed! He was {totalSeconds - record:f2} seconds slower.");
            }
        }
    }
}
