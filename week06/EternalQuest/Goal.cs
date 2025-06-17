public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        string complete = IsComplete() ? "[X]" : "[ ]";
        return $"{complete} {_name} ({_description})";
    }
}