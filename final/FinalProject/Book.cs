public class Book : MediaContent
{
    public Book(string name, string author, string collection, int year) : base ("Quote", name, author, collection, year)
    {

    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{_name}:\n >Author: {_author}\n >Collection: {_collection}\n >Year: {_year}");
    }
}