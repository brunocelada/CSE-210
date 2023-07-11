public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings (string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string MoreDetails()
    {
        return $"Weather: {_weather}";
    }
}