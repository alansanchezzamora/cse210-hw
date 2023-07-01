using System.Collections.Generic;
using System.IO;
public class Journal{
    
    public Entry _entry = new Entry();
    public List<Entry> _entries = new List<Entry>();

    public Prompt _prompt = new Prompt();


    public void SetEntries(string entry, string date, string prompt){

    }

    public void DisplayJournal(){
        Journal myJournal = new Journal();
        foreach(Entry e in myJournal._entries)
        {
            e.DisplayEntry();
        }

        string output = ("Press enter when you are ready to continue");
        Console.WriteLine(output);
        Console.ReadLine();
    }

    public void WriteEntry(){
        Journal myJournal = new Journal();        
        string testPrompt = _prompt.promptGenerator();
        Console.WriteLine(testPrompt);
        string entry = Console.ReadLine();
        string date = _entry.SetDate();
        
        _entry._prompt = testPrompt;
        _entry._entry = entry;
        _entry._date = date;
        myJournal._entries.Add(_entry);

    }

}
