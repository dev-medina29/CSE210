public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    public int _bonus;
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus):base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public void GetAmountCompleted(int amountCompleted)
    {
        _amountCompleted= amountCompleted;
    }
    
}