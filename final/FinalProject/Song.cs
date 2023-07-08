public class Song : MediaContent
{
    public Song(string name, string author, string album, int year) : base ("Song", name, author, album, year)
    {

    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{_name}:\n >Author: {_author}\n >Album: {_collection}\n >Year: {_year}");
    }
}