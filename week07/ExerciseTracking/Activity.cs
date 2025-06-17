public abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract float CalcSpeed();
    public abstract float CalcDistance();
    public abstract float CalcPace();

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {this.GetType().Name} ({_minutes}): Distance {CalcDistance():0.00} miles, Speed {CalcSpeed():0.00} mph, Pace {CalcPace():0.00} min per mile");
    }
}