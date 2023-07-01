using System.IO;
public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date} {_prompt} {_entry}");
    }

    public string GetEntry()
    {
        return _entry;
    }
    public void SetEntry(string text)
    {
        _entry = text;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public void SetPrompt(string text)
    {
        _prompt = text;
    }
    public string GetDate()
    {
        return _date;
    }
    public string SetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        _date = dateText;
        return _date;
    }
}

