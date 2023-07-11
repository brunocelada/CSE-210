public class Receptions : Event
{
    private string _RSVP;

    public Receptions (string title, string description, string date, string time, Address address, string rsvp) : base (title, description, date, time, address, "Reception")
    {
        _RSVP = rsvp;
    }

    public override string MoreDetails()
    {
        return $"RSVP Email: {_RSVP}";
    }
}