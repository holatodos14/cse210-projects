using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playingGame = "yes";

        while ( playingGame.ToLower() == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1 , 100);

            Console.WriteLine($"What is the magic number? {magicNumber}");
        
            int guessNumber = -1;
        
            int attempts = 0;
        
            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                
                if (int.TryParse(Console.ReadLine(), out guessNumber))
                {
                    attempts++;

                    if (guessNumber < magicNumber)
                        Console.WriteLine("Higher");
                    else if (guessNumber > magicNumber)
                        Console.WriteLine("Lower");
                    else
                        Console.WriteLine($"You guessed it in {attempts} attempts! ");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine("Would you like to play again? ");
            playingGame = Console.ReadLine();
        }

        Console.WriteLine("Thanks for play my game!");

        /* string response = "yes"; */
        
        
        /* while ( response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } */

    }
}