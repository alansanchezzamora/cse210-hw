using System.IO;
public class Entry
{
    public string _entry;
    public string _date;
    public string _prompt;

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt} {_entry}");
    }

    public string SetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
        return _date;
    }

    
}

