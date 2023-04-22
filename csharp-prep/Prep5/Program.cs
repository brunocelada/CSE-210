using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        // Call the DisplayWelcome function to print a message.
        DisplayWelcome();

        // Call the PromptUserName function to have the user name.
        string userName = PromptUserName();

        // Call the PromptUserNumber function to store the user number.
        int userNumber = PromptUserNumber();

        // Call the SquareNumber function to store the value into a variable.
        int sqNumber = SquareNumber(userNumber);

        // Print the results by calling the DisplayResults function.
        DisplayResult(userName, sqNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        /* Ask the user for a name, and return it
        as a string value.

        Parameters: none.
        Return: the name as a string.
        */
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {   
        return number * number;
    }

    static void DisplayResult(string name, int sqNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {sqNumber}");
    }
}