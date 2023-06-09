public class BreathingActivity : Activity
{
    public BreathingActivity ()
    {
        base.SetActivityName("Breathing Activity");
        base.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public int Initialize()
    {
        DisplayStartingMessage();

        Activity();

        DisplayEndingMessage();

        return GetDurationTime();
    }
    protected void Activity()
    {
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(GetDurationTime());

        while (DateTime.Now < finishTime)
        {
            Console.Write("Breathe in... ");
            Countdown(5);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown(5);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}