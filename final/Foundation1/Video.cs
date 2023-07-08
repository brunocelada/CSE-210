public class Video
{
    private string _title;
    private string _author;
    private int _lenght; // in seconds
    private List<Comment> _listComments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public void AddComment(string name, string commentText)
    {
        Comment comment = new Comment(name, commentText);
        _listComments.Add(comment);
    }
    public int NumberOfComments()
    {
        return _listComments.Count();
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLenght (in seconds): {_lenght}\nNumber of comments: {NumberOfComments()}");
        Console.WriteLine($"\nComment list:");
        foreach (Comment comment in _listComments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}