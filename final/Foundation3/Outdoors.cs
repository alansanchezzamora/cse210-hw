public class Outdoors : Event{
    private string _weather;
    public Outdoors(string eventTitle, string description, string date, string time, Address address, string weather) : base(eventTitle, description, date, time, address){
        _weather = weather;
    }

    public string DisplayFullDetails(){
        return $"Full Details: \nEvent Type: Outdoors \n{base.StandardDetails()}\nExpected Weather: {_weather}";
    }
    public string DisplayShortDescription(){
        return$"Event Type: Outdoor Event \n{base.ShortDescription()}";
    }
}