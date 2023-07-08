public class Serie : MediaContent
{
    private string _platform;
    public Serie(string name, string studio, string saga, int year, string platform) : base ("Song", name, studio, saga, year)
    {
        _platform = platform;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{_name}:\n >Studio: {_author}\n >Saga: {_collection}\n >Year: {_year}\n >Platform: {_platform}");
    }
}