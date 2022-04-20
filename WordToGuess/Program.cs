using System;

namespace WordToGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessingGame game = new GuessingGame("Harry Potter");

            Console.WriteLine(game.GetGuessProgress());

            while (true)
            {
                Console.WriteLine("Please enter next guess: ");
                string guess = Console.ReadLine();

                game.AddGuess(guess[0]);

                Console.WriteLine(game.GetGuessProgress());
            }
        }
    }
}
