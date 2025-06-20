public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            return _amountCompleted == _target ? _points + _bonus : _points;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        string complete = IsComplete() ? "[X]" : "[ ]";
        return $"{complete} {_name} ({_description}) -- Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
}