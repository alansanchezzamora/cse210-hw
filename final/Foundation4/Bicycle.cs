public class Bicycle : Activity{
    private int _speed;
    
public Bicycle(string date, int length, int speed) : base(date, length){
    _speed = speed;
}

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return GetLength() / _speed;
    }
    public override double GetDistance()
    {
        return (_speed / 60 ) * GetLength();
    }
}