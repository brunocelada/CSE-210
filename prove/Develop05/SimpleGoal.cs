public class SimpleGoal : Goal
{
    private bool _status;

    public SimpleGoal(string name, string description, int points, bool status) : base ("Simple Goal", name, description, points)
    {
        _status = status;
    }

    private void SetCompleted()
    {
        _status = true;
    }
    private string GetStatus()
    {
        if (_status)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    public override string DisplayGoal()
    {
       return $"[{GetStatus()}] {_name} ({_description})";
    }
    public override int RecordEvent()
    {
        SetCompleted();
        return _pointsEarned;
    }
    public override string SaveInfo()
    {
        return $"Simple Goal:{_name}~{_description}~{_pointsEarned}~{_status}";
    }
}