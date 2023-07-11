public class Running : Activity{
    private float _distance; 

public Running(string date, int length, int distance) : base(date, length){
    _distance = distance;
}

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return GetLength() / _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60;
    }
}