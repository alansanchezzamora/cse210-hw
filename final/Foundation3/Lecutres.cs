public class Lectures : Event{
    private string _speaker;
    private int _capacity;
    public Lectures(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address){
        _speaker = speaker;
        _capacity = capacity;
    }

    public string DisplayFullDetails(){
        return $"Full Details: \nEvent Type: Lecture \n{base.StandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string DisplayShortDescription(){
        return$"Event Type: Lecture \n{base.ShortDescription()}";
    }
}