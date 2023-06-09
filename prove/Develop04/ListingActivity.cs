public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListingActivity ()
    {
        base.SetActivityName("Listing Activity");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Initialize()
    {
        DisplayStartingMessage();

        Activity();

        DisplayEndingMessage();
    }
    protected void Activity()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(0, _prompts.Count - 1)];

        Console.WriteLine("List as many responses you can to the following prompt:\n");
        Console.WriteLine($"  ---{randomPrompt}---\n");

        Console.Write("You may begin in: ");
        Countdown(5);

        Console.Clear();
        Console.WriteLine($"--{randomPrompt}--\n");

        Console.WriteLine($"You listed {ListingAnswers()} items!");
    }
    private int ListingAnswers()
    {
        List<string> answers = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(GetDurationTime());
        
        while (DateTime.Now < finishTime)
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }

        return answers.Count;
    }
}