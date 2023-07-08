public class Quote : MediaContent
{
    public Quote(string quote, string author, string collection, int year) : base ("Quote", quote, author, collection, year)
    {

    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"  ---{_name}---\n\n >Author: {_author}\n >Collection: {_collection}\n >Year: {_year}");
    }
}