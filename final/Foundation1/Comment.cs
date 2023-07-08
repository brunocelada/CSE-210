public class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($" > Name (user): {_name}\n > Comment text: {_commentText}");
        Console.WriteLine();
    }
}