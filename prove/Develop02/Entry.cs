public class Entry
{
    public string _answer;
    public string _prompt;
    public string _dateTime;
    public string _mood;

    public void DisplayEntry(){
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Answer: {_answer}");
        Console.WriteLine($"Mood: {_mood}");
    }
}