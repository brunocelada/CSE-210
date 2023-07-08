public class MenuContainer : Program
{
    private List<string> _userMenu = new List<string>()
    {
        "Add new item",
        "Display list of items",
        "Modify an item",
        "Delete item",
        "Request random activity",
        "(Initial Menu)"
    };
    private List<string> _categoriesMenu = new List<string>()
    {
        "Foods",
        "Movies",
        "Series",
        "Songs",
        "Books",
        "Quotes",
        "Friends",
    };
    private List<string> _foodMenu = new List<string>()
    {
        "Edit recipe",
        "Add place to eat",
        "Remove place to eat",
        "(Back Menu)"
    };
    private List<string> _friendMenu = new List<string>()
    {
        "Add new friend",
        "Edit friend info",
        "List of friends",
        "Remove friend",
        "(Back Menu)"
    };
    private List<string> _bookMenu = new List<string>()
    {
        "Add new book",
        "List of books",
        "Remove book",
        "(Back Menu)"
    };
    private List<string> _movieMenu = new List<string>()
    {
        "Add new movie",
        "List of movies",
        "Remove movie",
        "(Back Menu)"
    };
    private List<string> _serieMenu = new List<string>()
    {
        "Add new serie",
        "List of series",
        "Remove serie",
        "(Back Menu)"
    };
    private List<string> _songMenu = new List<string>()
    {
        "Add new song",
        "List of songs",
        "Remove song",
        "(Back Menu)"
    };
    private List<string> _quoteMenu = new List<string>()
    {
        "Add new quote",
        "List of quotes",
        "Remove quote",
        "(Back Menu)"
    };

    public User UserMenu(User user)
    {
        int userOption = 0;
        //foodOption = 0, friendOption = 0, bookOption = 0, movieOption = 0, serieOption = 0, songOption = 0, quoteOption = 0;

        Console.Clear();
        Console.WriteLine(":light_bulb: Suggestions:");
        Console.WriteLine("> If you're in a good mood, add new items to the list. It will help you in the future.");
        Console.WriteLine("> If you're sad or unmotivated, look for some specific or random activities to do from those previously added to your lists.");

        while (userOption != _userMenu.Count())
        {
            userOption = DisplayMenu(_userMenu);

            switch (userOption)
            {
                case 1:
                    // Add new item                   
                    break;
                
                case 2:
                    // Display list of items
                    DisplayItems(user);
                    Console.WriteLine("\n");
                    break;

                case 3:
                    // Modify an item
                
                case 4:
                    // Delete item
                    break;

                case 5:
                    // Request random activity
                    break;

                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }
        }
        return user;
    }
    private void DisplayItems(User user)
    {
        int categoryOption = 0;

        while (categoryOption != _categoriesMenu.Count())
        {
            categoryOption = DisplayMenu(_categoriesMenu);

            switch (categoryOption)
            {
                case 1:
                // Food
                user.DisplayItems(1);
                break;
            case 2:
                // Movies
                user.DisplayItems(2);
                break;
            case 3:
                // Series
                user.DisplayItems(3);
                break;
            case 4:
                // Songs
                user.DisplayItems(4);
                break;
            case 5:
                // Books
                user.DisplayItems(5);
                break;
            case 6:
                // Quotes
                user.DisplayItems(6);
                break;
            case 7:
                // Friends
                user.DisplayItems(7);
                break;
            default:
                break;
            }
        }
    }
    public virtual void DisplayInfo(){}
}