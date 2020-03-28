using System;

namespace mostPowerfullWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            double mostPowerfullWord = 0;
            string mostPowerfullName = string.Empty;

            while (word != "End of words")
            {

                char firstLetter = word[0];
                double currentWord = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    int letter = word[i];
                    currentWord += letter;
                }

                if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i' || firstLetter == 'o' || firstLetter == 'u' || firstLetter == 'y')
                {
                    currentWord *= word.Length;
                }
                else if (firstLetter == 'A' || firstLetter == 'E' || firstLetter == 'I' || firstLetter == 'O' || firstLetter == 'U' || firstLetter == 'Y')
                {
                    currentWord *= word.Length;
                }
                else
                {
                    Math.Floor(currentWord /= word.Length);
                }

                if (currentWord > mostPowerfullWord)
                {
                    mostPowerfullWord = currentWord;
                    mostPowerfullName = word;
                }

                word = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {mostPowerfullName} - {mostPowerfullWord}");
        }
    }
}
