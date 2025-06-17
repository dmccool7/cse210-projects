public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override float CalcSpeed()
    {
        return 60 / CalcPace();
    }

    public override float CalcDistance()
    {
        return _laps * 50 / 1000 * 0.62f;
    }

    public override float CalcPace()
    {
        return _minutes / CalcDistance();
    }
}