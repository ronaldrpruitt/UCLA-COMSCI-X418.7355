using System;

namespace ronpruitt_firstapp
{
    internal class Program
    {
        public const int MAX_NUMBER = 100;
        private static readonly int numberToGuess = GetRandomNumber();
        private static int guessNumber = 0;
        private static int numberOfGuesses = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'Guess the Number'");
            Console.WriteLine("The number is between 1 and {0}.\n", MAX_NUMBER);

            while (guessNumber != numberToGuess)
            {
                numberOfGuesses++;
                guessNumber = GetGuessNumber();
                if (guessNumber > numberToGuess)
                {
                    Console.WriteLine("{0} is too high!\n", guessNumber);
                }
                else if (guessNumber < numberToGuess)
                {
                    Console.WriteLine("{0} is too low!\n", guessNumber);
                }
                else
                {
                    Console.WriteLine("\n{0} is right! Congratulations.", guessNumber);
                    Console.WriteLine("Number of guesses: {0}", numberOfGuesses);
                    PauseScreen();
                }
            }
        }

        public static int GetGuessNumber()
        {
            int guessNumber;
            Console.Write("Enter your integer guess number: ");
            int.TryParse(Console.ReadLine(), out guessNumber);
            return guessNumber;
        }

        public static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(MAX_NUMBER) + 1;
        }

        public static void PauseScreen()
        {
            Console.WriteLine("\nEnter any key to continue...");
            Console.ReadKey();
        }
    }
}