public abstract class Goal
{
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _pointsEarned;

    public Goal(string goalType, string name, string description, int pointsEarned)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _pointsEarned = pointsEarned;
    }
    
    public abstract string DisplayGoal();
    public abstract int RecordEvent();
    public abstract string SaveInfo();

}