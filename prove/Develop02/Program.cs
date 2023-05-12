// JOURNAL PROGRAM

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal!");
        Console.WriteLine();

        // Display the options menu.
        int userOption = DisplayMenu();
        
        // Generate the Journal Class.
        Journal journal = new Journal();

        // Ask the user for an option in a loop, until he/she decides to quit the program.
        bool ind = true;
        while (ind){
            if (userOption == 1){
                // Option 1. Write new entry
                journal.WriteNewEntry();

                Console.WriteLine();
                Console.WriteLine("Do you want to do something else?");
                userOption = DisplayMenu();
            }
            else if (userOption == 2){
                // Option 2. Display Journal
                Console.WriteLine();
                journal.DisplayJournal();

                Console.WriteLine("Do you want to do something else?");
                userOption = DisplayMenu();
            }
            else if (userOption == 3){
                // Option 3. Load Journal
                journal.LoadFile();

                Console.WriteLine();
                Console.WriteLine("Do you want to do something else?");
                userOption = DisplayMenu();
            }
            else if (userOption == 4){
                // Option 4. Save Journal
                journal.SaveFile();             

                Console.WriteLine();
                Console.WriteLine("Do you want to do something else?");
                userOption = DisplayMenu();
            }
            else if (userOption == 5){
                // Option 5. Quit
                Console.WriteLine("Do you want to close the Journal Program? Make sure you have saved the file.");
                Console.Write("Yes/No ");
                string close_Option = Console.ReadLine();
                if (close_Option.ToLower() == "yes" || close_Option.ToLower() == "y"){
                    break;
                }
                else {
                    userOption = DisplayMenu();
                }
            }
            else {
                // Wrong number.
                Console.Write("Please, enter a valid option ");
                userOption = int.Parse(Console.ReadLine());
            }
        }
        // Option 5. Quit - Finishing the program.
        Console.WriteLine();
        Console.WriteLine("Thank you for writing your Journal! See you!!");
        Console.WriteLine();
    }

    static int DisplayMenu(){
        List<string> menu = new List<string>();
        // Menu Options:
        menu.Add("1. Write new entry");
        menu.Add("2. Display Journal");
        menu.Add("3. Load Journal");
        menu.Add("4. Save Journal");
        menu.Add("5. Quit");

        // Print the menu options.
        foreach (string option in menu){
            Console.WriteLine(option);
        }

        Console.Write("Please, select an option: ");
        int userOption = int.Parse(Console.ReadLine());

        return userOption;
    }
}