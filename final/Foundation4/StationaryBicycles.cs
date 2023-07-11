public class StationaryBicycles : Activity
{
    private float _speed; // In km per hour.

    public StationaryBicycles (string date, float minutes, float speed) : base (date, minutes, "Stationary Bicycles")
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return (_speed / 60) * _minutes;
    }
    public override float GetSpeed()
    {
        return _speed;
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
}