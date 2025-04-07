using System.Runtime.CompilerServices;

public class Biking : Activity
{
    private double _speed;

    public Biking(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;
    public override double GetDistance() => _speed * GetMinutes() / 60;
    public override double GetPace() => 60 / _speed;
}
