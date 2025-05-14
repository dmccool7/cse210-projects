using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            Random randomGenerator = new Random();
            int num = randomGenerator.Next(1, 100);

            int guess = 0;
            int numGuesses = 0;

            while (guess != num)
            {
                Console.Write("What is your guess? ");
                string numGuess = Console.ReadLine();
                guess = int.Parse(numGuess);

                numGuesses ++;

                if (guess > num)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < num)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"Number of Guesses: {numGuesses}");
            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}