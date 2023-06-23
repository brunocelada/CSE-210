public class EternalGoal : Goal
{
    public EternalGoal (string name, string description, int points) : base ("Eternal Goal", name, description, points)
    {

    }

    public override string DisplayGoal()
    {
        return $"[ ] {_name} ({_description})";
    }
    public override int RecordEvent()
    {
        return _pointsEarned;
    }
    public override string SaveInfo()
    {
        return $"Eternal Goal:{_name}~{_description}~{_pointsEarned}";
    }
}