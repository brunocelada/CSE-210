using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Ask the user a magic number.
        // Console.Write("Write your magic number ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Set a variable for later (receiving the user's option).
        string response = "";

        // Play one time the game, and then ask the user 
        // if he/she wants to play again, and loop the game
        // all the times he/she enters "yes".
        do {
            // Generate a random magic number.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Set the used variables.
            int attempts = 1;
            int guess = -1;

            // Ask the user for a guess and loop the hints 
            // until he/she finds the magic number.
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    attempts ++;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    attempts ++;
                }
            }

            Console.WriteLine("That's the magic number!");
            Console.WriteLine($"You have tried {attempts} times.");

            // Ask if the user wants to play again.
            Console.Write("\nDo you want to play again? ");
            response = Console.ReadLine();

        } while (response == "yes" || response == "YES");
    }
}