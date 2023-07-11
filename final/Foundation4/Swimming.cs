public class Swimming : Activity
{
    private float _laps;

    public Swimming (string date, float minutes, float laps) : base (date, minutes, "Swimming")
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }
    public override float GetPace()
    {
        return _minutes / GetDistance();
    }
}