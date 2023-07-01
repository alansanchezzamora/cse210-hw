using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userResponse = -1;
        Journal myJournal = new Journal();
        
        while(userResponse != 5){
        Console.Clear();
        Console.WriteLine("Welcome to the journal Program \nPlease select one of the following choices: ");
        Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        Console.Write("What would you like to do? ");
        userResponse = int.Parse(Console.ReadLine());

            if(userResponse == 1){
                Console.Clear();
                myJournal.WriteEntry();
            }
            else if(userResponse == 2){
                Console.Clear();
                myJournal.DisplayJournal();
                
            }
            else if(userResponse == 3){
                Console.Clear();
                Console.Write("Open file: ");
                string fileName = Console.ReadLine();
                string [] userFile = System.IO.File.ReadAllLines(fileName);
                foreach(string line in userFile){
                    Entry newEntry = new Entry();
                    string [] parts = line.Split("±");
                    newEntry._date = parts[0];
                    newEntry._prompt = parts[1];
                    newEntry._entry = parts[2];
                    myJournal._entries.Add(newEntry);
                } 
            }
            else if(userResponse == 4){
                Console.Clear();
                Console.Write("Save to file: ");
                string filename = Console.ReadLine();
                using(StreamWriter OutputFile = new StreamWriter(filename))
                {
                    foreach(Entry a in myJournal._entries){
                        OutputFile.WriteLine($"{a._date}±{a._prompt}±{a._entry}");                        
                    }

                }
            }
            else{
                Console.WriteLine("Remember to come back tomorrow");
            }
        }
    }


}