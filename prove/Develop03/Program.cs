using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        List<Scripture> scriptureList = new List<Scripture>();

        string userInput = "";

        // **STRETCH CHALLENGUE**
            // Load a list of scriptures from a file, display them as a list
            // and let the user choose one to memorize.
            
        // Clear the console and load the scripture from the file.
        Console.Clear();
        LoadFile(scriptureList);

        // Select a scripture from the avaliable list.
        Console.WriteLine("Select a scripture: ");
        DisplayReferences(scriptureList);
        int option = int.Parse(Console.ReadLine());

        Console.Clear();
        
        while (userInput.ToLower() != "quit"){
            // Clear the console.
            Console.Clear();
            
            // Ask the user to continue pressing enter or quit the program.
            Console.WriteLine(scriptureList[option - 1].GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            // Check if all the scripture is already hidden and display the scripture.
            bool finished = scriptureList[option - 1].Memorize();
            // If it is all hidden, then finish the program.
            if (finished == true){
                break;
            }
        }
    }
    static void DisplayReferences(List<Scripture> scriptureList){
        int i = 1;
        foreach (Scripture scripture in scriptureList){
            Console.WriteLine($"{i}> {scripture.GetReference()}");
            i++;
        }
    }
    static void LoadFile(List<Scripture> scriptureList){
        // In case you want to use a different file each time, use the code:
            // Console.Write("Name of the file: ");
            // string fileName = Console.ReadLine();
        // and erase the line that set the fileName value.
        string fileName = "scriptureFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines){
            string[] parts = line.Split("~");

            Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            
            List<Word> text = new List<Word>();

            string[] words = parts[4].Split(" ");
            foreach (string word in words){
                Word newWord = new Word(word);
                text.Add(newWord);
            }

            Scripture scripture = new Scripture(reference, text);
            scriptureList.Add(scripture);
        }
    }
}