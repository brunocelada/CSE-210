public class Movie : MediaContent
{
    private string _platform;
    public Movie(string name, string studio, string saga, int year, string platform) : base ("Movie", name, studio, saga, year)
    {
        _platform = platform;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{_name}:\n >Studio: {_author}\n >Saga: {_collection}\n >Year: {_year}\n >Platform: {_platform}");
    }
}