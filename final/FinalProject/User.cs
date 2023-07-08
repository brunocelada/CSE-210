using System;

public class User : Program
{
    private string _name;
    private string _password;
    private List<Food> _listFoods;
    private List<Song> _listSongs;
    private List<Movie> _listMovies;
    private List<Serie> _listSeries;
    private List<Book> _listBooks;
    private List<Quote> _listQuotes;
    private List<Friend> _listFriends;

    public void SetUserName(string name)
    {
        _name = name;
    }
    public void SetPassword(string password)
    {
        _password = password;
    }
    public void SetSongsList(List<Song> listSongs)
    {
        _listSongs = listSongs;
    }
    public void SetFoodsList(List<Food> listFoods)
    {
        _listFoods = listFoods;
    }
    public void SetMoviesList(List<Movie> listMovies)
    {
        _listMovies = listMovies;
    }
    public void SetSeriesList(List<Serie> listSeries)
    {
        _listSeries = listSeries;
    }
    public void SetBooksList(List<Book> listBooks)
    {
        _listBooks = listBooks;
    }
    public void SetQuotesList(List<Quote> listQuotes)
    {
        _listQuotes = listQuotes;
    }
    public void SetFriendsList(List<Friend> listFriends)
    {
        _listFriends = listFriends;
    }
    public bool VerifyPassword(string password)
    {
        if (_password == password)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetPassword()
    {
        return _password;
    }
    public void DisplayItems(int index)
    {
        switch (index)
        {
            case 1:
                // Food
                foreach (Food food in _listFoods)
                {
                    food.DisplayInfo();
                }
                break;
            case 2:
                // Movies
                foreach (Movie movie in _listMovies)
                {
                    movie.DisplayInfo();
                }
                break;
            case 3:
                // Series
                foreach (Serie serie in _listSeries)
                {
                    serie.DisplayInfo();
                }
                break;
            case 4:
                // Songs
                foreach (Song song in _listSongs)
                {
                    song.DisplayInfo();
                }
                break;
            case 5:
                // Books
                foreach (Book book in _listBooks)
                {
                    book.DisplayInfo();
                }
                break;
            case 6:
                // Quotes
                foreach (Quote quote in _listQuotes)
                {
                    quote.DisplayInfo();
                }
                break;
            case 7:
                // Friends
                foreach (Friend friend in _listFriends)
                {
                    friend.DisplayInfo();
                }
                break;
            default:
                break;
        }
    }
    public void ResetUserInfo()
    {
        _name = null;
        _password = null;
        _listFoods = null;
        _listSongs = null;
        _listMovies = null;
        _listSeries = null;
        _listBooks = null;
        _listQuotes = null;
        _listFriends = null;
    }
}