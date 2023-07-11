public class Event
{
    protected string _title;
    protected string _typeOfEvent;
    protected string _description;
    protected string _date; // Let me know it this variable needs to be a DateOnly type.
    protected string _time; // Let me know it this variable needs to be a TimeOnly type.
    protected Address _address;

    public Event (string title, string description, string date, string time, Address address, string typeOfEvent)
    {
        _title = title;
        _typeOfEvent = typeOfEvent;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayStandardDetails()
    {
        return $"'{_title}' - {_description}\nDate and time: {_date} {_time}\nAddress: {_address.DisplayAddress()}";
    }
    public string DisplayFullDetails()
    {
        return $"'{_title}' - {_description}\nEvent: {_typeOfEvent}\nDate and time: {_date} {_time}\nAddress: {_address.DisplayAddress()}\n{MoreDetails()}";
    }
    public string DisplayShortDescription()
    {
        return $"Event: {_typeOfEvent}\n'{_title}'\nDate: {_date}";
    }
    public virtual string MoreDetails()
    {
        return $"";
    }
}