using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        List<int> counters = new List<int>(){0, 0, 0, 0};
        // Index 0: total activities
        // Index 1: total breathing activity
        // Index 2: total reflection activity
        // Index 3: total listing activity

        int userOption = 0;

        // Caution! the first time you run this code, you will need the ActivitySummary.txt file already created on your folder.
        string fileName = "ActivitySummary.txt";
        counters = LoadFile(fileName);

        while (userOption != 5)
        {
            // Clear the screen and display the menu.
            DisplayMenu();

            userOption = int.Parse(Console.ReadLine());

            switch (userOption)
            {
                case 1:
                        // Breathing activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Initialize();

                    counters[0] ++;
                    counters[1] ++;
                    break;

                case 2:
                        // Reflection activity
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Initialize();

                    counters[0] ++;
                    counters[2] ++;
                    break;

                case 3:
                        // Listing activity
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Initialize();

                    counters[0] ++;
                    counters[3] ++;
                    break;

                case 4:
                    // Display summary.
                    Console.Clear();
                    DisplaySummary(fileName, counters);

                    Console.WriteLine("\nPress enter to return to the menu\n");
                    Console.ReadLine();
                    break;

                default:
                    break;
            }
        }
    
    SaveFile(fileName, counters);
    }

    static void DisplayMenu()
    {
        Console.Clear();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflection activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Display summary");
        Console.WriteLine("  5. Quit");
        Console.Write("Select a choice from the menu: ");
    }
    static void DisplaySummary(string fileName, List<int> counters)
    {
    // *STRETCH CHALLENGUE*
    // Keeping a log of how many times activities were performed.

    Console.WriteLine($"You have completed a total of {counters[0]} activities");
    Console.WriteLine($"> Total of breathing activities completed: {counters[1]}");
    Console.WriteLine($"> Total of reflection activities completed: {counters[2]}");
    Console.WriteLine($"> Total of listing activities completed: {counters[3]}");
    }
    static void SaveFile(string fileName, List<int> counters)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine($"{counters[0]}~{counters[1]}~{counters[2]}~{counters[3]}");
        }
    }
    static List<int> LoadFile(string fileName)
    {
        List<int> counters = new List<int>(){0, 0, 0, 0};
        string line = System.IO.File.ReadAllText(fileName);

        string[] parts = line.Split("~");

        counters[0] = int.Parse(parts[0]);
        counters[1] = int.Parse(parts[1]);
        counters[2] = int.Parse(parts[2]);
        counters[3] = int.Parse(parts[3]);

        return counters; 
    }
}