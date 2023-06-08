using System.Collections.Generic;
using System.IO;
public class Journal{
    public List<Entry> _entries = new List<Entry>();

    public void SetEntries(string entry, string date, string prompt){

    }

    public void DisplayJournal(){
        foreach(Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }

}
