public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity ()
    {
        base.SetActivityName("Reflection Activity");
        base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Initialize()
    {
        DisplayStartingMessage();

        Activity();

        DisplayEndingMessage();
    }
    private void Activity()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(0, _prompts.Count - 1)];

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"  ---{randomPrompt}---  ");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("You may begin in: ");
        Countdown(5);

        Console.Clear();
        Console.WriteLine($"--{randomPrompt}--\n");

        DisplayQuestions();
    }
    private void DisplayQuestions()
    {
        Random random = new Random();
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(GetDurationTime());

        while (DateTime.Now < finishTime)
        {
            Console.Write($"> {_questions[random.Next(0, _questions.Count - 1)]} ");
            ClockAnimation(15);
            Console.WriteLine();
        }
    }
}