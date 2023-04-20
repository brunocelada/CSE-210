using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // Asking the first and last names
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Printing the "James Bond" phrase
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}