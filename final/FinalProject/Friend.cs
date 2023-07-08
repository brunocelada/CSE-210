public class Friend : MenuContainer
{
    private string _name;
    private string _phone;
    private string _email;
    private List<string> _activities;

    public Friend(string name, string phone, string email = null)
    {
        _name = name;
        _phone = phone;
        _email = email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
    public void AddActivity(string activity)
    {
        _activities.Add(activity);
    }
    public void ChangePhoneNumber(string phone)
    {
        _phone = phone;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"{_name}:\n >Phone: {_phone}\n >Email: {_email}\n >Activities:");
        DisplayList(_activities);
    }
}