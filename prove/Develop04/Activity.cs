public class Activity
{
    private int _durationTime;
    private string _activityName;
    private string _description;

    // Getters and setters.
    public void SetActivityName (string activityName)
    {
        _activityName = activityName;
    }
    public void SetDescription (string description)
    {
        _description = description;
    }
    private void SetDurationTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _durationTime = int.Parse(Console.ReadLine());
    }
    public int GetDurationTime()
    {
        return _durationTime;
    }

    // Modules.
    protected void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_activityName}\n");

        Console.WriteLine(_description);
        Console.WriteLine();

        SetDurationTime();
        Console.WriteLine();

        Console.Write("Get ready to begin... ");
        Countdown(5);
        Console.Clear();
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ClockAnimation(4);

        Console.WriteLine($"\nCongrats! You have completed {_durationTime} seconds of the {_activityName}");
        ClockAnimation(6);
    }

    // Timers and animations.
    protected void Countdown(int top)
    {
        while (top > 0 && top < 10)
        {
            Console.Write(top);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            top --;
        }
    }
    protected void ClockAnimation(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(duration);

        string[] chars = {"|", "/", "-", "\\"};

        int i = 0;
        int j = 0;

        while (DateTime.Now < finishTime)
        {
            if (j > 3)
                {
                    j = 0;
                }
                Console.Write(chars[j]);

                Thread.Sleep(200);
                Console.Write("\b \b");

                i++;
                j++;
        }
    }
}