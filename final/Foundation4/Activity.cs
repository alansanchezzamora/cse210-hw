public abstract class Activity{
    private string _date;
    private int _length;

    public Activity(string date, int length){
        _date = date;
        _length = length;
    }
    
    public int GetLength(){
        return _length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace(); 

    public void Summary(){
        Console.WriteLine($"{_date} {GetType().Name} ({GetLength()} min) - Distance {GetDistance()} km, Speed {GetSpeed()} km/h, pace: {GetPace()} min per km");
    }
}