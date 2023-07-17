using System.Collections.Generic;
using System.IO;
public class Journal{
    public List<Entry> entries = new List<Entry>();
    public Prompt Prompt;
    
    string prompt0;
    public void AddEntry(){
        prompt0 = Prompt.RandomPrompt();
        Entry Entry = new Entry();

        Console.WriteLine(prompt0);
        Entry._prompt = prompt0;
        Entry._entry = Console.ReadLine();
        entries.Add(Entry);
    }


}
