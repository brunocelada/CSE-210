public class MediaContent : MenuContainer
{
    protected string _type;
    protected string _name;
    protected string _author;
    protected string _collection;
    protected int _year;

    public MediaContent(string type, string name, string author, string collection, int year)
    {
        _type = type; _name = name; _author = author; _collection = collection; _year = year;
    }
    public override void DisplayInfo(){}
}