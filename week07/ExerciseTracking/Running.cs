public class Running : Activity
{
    private float _distance;

    public Running(string date, int minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override float CalcSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override float CalcDistance()
    {
        return _distance;
    }

    public override float CalcPace()
    {
        return _minutes / _distance;
    }
}