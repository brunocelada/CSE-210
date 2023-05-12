public class Prompt
{
    public List<string> _promptList = new List<string>();

    public void FillPromptList(){
        _promptList.Clear();
        _promptList.Add("Who was the most interesting person I interacted with today?");
        _promptList.Add("What was the best part of my day?");
        _promptList.Add("How did I see the hand of the Lord in my life today?");
        _promptList.Add("What was the strongest emotion I felt today?");
        _promptList.Add("If I had one thing I could do over today, what would it be?");
        _promptList.Add("What are you thankful for today?");
        _promptList.Add("Who were you able to help today, directly or indirectly?");
    }
    
    public string GetRandomPrompt(){
        FillPromptList();

        Random random = new Random();
        int randomPromptNumber = random.Next(0, _promptList.Count);

        return _promptList[randomPromptNumber];
    }
}