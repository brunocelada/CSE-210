using System.IO;
public class Journal
{
    public List<Entry> _entriesList = new List<Entry>();
    public Prompt _promptList = new Prompt();
    public void WriteNewEntry(){
        // Create a new Entry object.
        Entry _entry = new Entry();

        // Display and save the random prompt into the _entry object.
        _entry._prompt = _promptList.GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine($"Prompt: {_entry._prompt}");

        // Save the user's answer into the _entry object.
        Console.Write("> ");
        _entry._answer = Console.ReadLine();

        // Save the DateTime value into the _entry object.
        DateTime _dateTimeNow = DateTime.Now;
        _entry._dateTime = _dateTimeNow.ToString();

        // Save the mood number into the _entry object.
        Console.WriteLine("Your mood on a scale of 1 to 5 (1 = Worst, 5 = Great)");
        Console.Write("> ");
        _entry._mood = Console.ReadLine();

        // Save the Entry object data.
        _entriesList.Add(_entry);

        Console.WriteLine();
        Console.WriteLine("Entry added successfully!");
    }
    public void DisplayJournal(){
        decimal sumMoods = 0;
        foreach (Entry entry in _entriesList){
            entry.DisplayEntry();
            Console.WriteLine();

            int mood = int.Parse(entry._mood);
            sumMoods += mood;
        }
        // **Creativity and Exceeding Requirements**
        // Compute and display the average of moods.
        decimal averageMoods = decimal.Round(sumMoods/_entriesList.Count, 2);
        Console.WriteLine($"Average of moods: {averageMoods}");
        Console.WriteLine();
    }
    public void SaveFile(){
        Console.Write("Name of the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach (Entry entry in _entriesList){
                outputFile.WriteLine($"{entry._dateTime}~{entry._prompt}~{entry._answer}~{entry._mood}");
            }
        }
    }
    public void LoadFile(){
        // Clean the entries list.
        _entriesList.Clear();

        Console.Write("Name of the file: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines){
            Entry _entry = new Entry();

            string[] parts = line.Split("~");

            _entry._dateTime = parts[0];
            _entry._prompt = parts[1];
            _entry._answer = parts[2];
            _entry._mood = parts[3];

            _entriesList.Add(_entry);
        }
    }
}