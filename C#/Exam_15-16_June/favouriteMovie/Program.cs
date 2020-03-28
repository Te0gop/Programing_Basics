using System;

namespace favouriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int movieCounter = 0;
            int bestMovie = 0;
            string bestMovieName = string.Empty;

            while (movieName != "STOP")
            {
                movieCounter++;
                int currentMovie = 0;

                for (int i = 0; i < movieName.Length; i++)
                {
                    char letter = movieName[i];
                    int letterASCII = movieName[i];
                    currentMovie += letterASCII;

                    if (letter >= 'a' && letter <= 'z')
                    {
                        currentMovie -= 2 * movieName.Length;

                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        currentMovie -= movieName.Length;

                    }
                }
                if (currentMovie > bestMovie)
                {
                    bestMovie = currentMovie;
                    bestMovieName = movieName;
                }


                if (movieCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }

                movieName = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {bestMovieName} with {bestMovie} ASCII sum.");

        }
    }
}
