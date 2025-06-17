public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int minutes, float speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override float CalcDistance()
    {
        return _minutes / 60.0f * _speed;
    }

    public override float CalcPace()
    {
        return 60 / _speed;
    }

    public override float CalcSpeed()
    {
        return _speed;
    }
}