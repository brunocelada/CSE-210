public class ChecklistGoal : Goal
{
    int _totalTimes;
    int _currentTimes;
    int _bonusPoints;
    
    public ChecklistGoal (string name, string description, int points, int bonusPoints, int totalTimes, int currentTimes = 0) : base ("Checklist Goal", name, description, points)
    {
        _bonusPoints = bonusPoints;
        _totalTimes = totalTimes;
        _currentTimes = currentTimes;
    }
    public string GetStatus()
    {
        if (_currentTimes == _totalTimes)
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
       return $"[{GetStatus()}] {_name} ({_description}) -- Currently completed: {_currentTimes}/{_totalTimes}";
    }
    public override int RecordEvent()
    {
        _currentTimes ++;
        if (_currentTimes == _totalTimes)
        {
            return _pointsEarned + _bonusPoints;
        }
        else
        {
            return _pointsEarned;
        }
    }
    public override string SaveInfo()
    {
        return $"Checklist Goal:{_name}~{_description}~{_pointsEarned}~{_bonusPoints}~{_totalTimes}~{_currentTimes}";
    }
}