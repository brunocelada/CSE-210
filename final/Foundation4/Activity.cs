public abstract class Activity
{
    private string _date;
    protected float _minutes; // Lenght in minutes
    private string _typeOfActivity;

    public Activity (string date, float minutes, string typeOfActivity)
    {
        _date = date;
        _minutes = minutes;
        _typeOfActivity = typeOfActivity;
    }

    public abstract float GetDistance(); // In km.
    public abstract float GetSpeed(); // Kilometers per hour.
    public abstract float GetPace(); // Minutes per kilometer.
    public string GetSummary()
    {
        return $"{_date} {_typeOfActivity} ({_minutes} min) - Distance: {RoundFloat(GetDistance())} km, Speed: {RoundFloat(GetSpeed())} kph, Pace: {RoundFloat(GetPace())} min per km";
    }
    public float RoundFloat(float number)
    {
        return (float)Math.Round(number, 2);
    }
}