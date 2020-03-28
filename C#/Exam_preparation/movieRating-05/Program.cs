using System;

namespace movieRating_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int films = int.Parse(Console.ReadLine());

            string bestMovieName = string.Empty;
            string worstMovieName = string.Empty;
            double besttRating = double.MinValue;
            double lowestRating = double.MaxValue;
            double ratingSum = 0;
  

            for (int i = 0; i < films; i++)
            {
                string currentMovieName = Console.ReadLine();
                double currentMovieRating = double.Parse(Console.ReadLine());

                if (currentMovieRating > besttRating)
                {
                    besttRating = currentMovieRating;
                    bestMovieName = currentMovieName;
                }
                if (currentMovieRating < lowestRating)
                {
                    lowestRating = currentMovieRating;
                    worstMovieName = currentMovieName;
                }
                ratingSum += currentMovieRating;
                
            }
            double averageRating = ratingSum / films;

            Console.WriteLine($"{bestMovieName} is with highest rating: {besttRating:F1}");
            Console.WriteLine($"{worstMovieName} is with lowest rating: {lowestRating:F1}");
            Console.WriteLine($"Average rating: {averageRating:F1}");

        }
    }
}
