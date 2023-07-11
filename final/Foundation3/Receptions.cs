public class Receptions : Event{
    private string _mail;
    public Receptions(string eventTitle, string description, string date, string time, Address address, string mail) : base(eventTitle, description, date, time, address){
        _mail = mail;
    }

    public string DisplayFullDetails(){
        return $"Full Details: \nEvent Type: Reception \n{base.StandardDetails()}\nRSVP mail: {_mail}";
    }
    public string DisplayShortDescription(){
        return$"Event Type: Reception \n{base.ShortDescription()}";
    }
}