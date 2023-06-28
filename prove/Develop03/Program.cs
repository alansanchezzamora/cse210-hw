using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Si me amais guardad mis mandamientos";
        string referenceText = "Juan 14:25";
        Scripture myScripture = new Scripture(scriptureText);
        Reference myReference = new Reference(referenceText);
        myReference.ShowReference();
        myScripture.DisplayScripture();
                
                
        bool answer = false;
        while (myScripture.IsCompletelyHidden(myScripture.GetScripture()) && answer ){
            Console.Clear();
            myReference.ShowReference();
            myScripture.DisplayScripture();
            Console.Write("\n\nPress enter to hide words... ");
            string next = Console.ReadLine();
            next.ToLower();
            if (next == "quit"){
                answer = false;
            } else {
                myScripture.HideWords(myScripture.GetScripture());
            }
            

        }
        Console.Clear();
        myReference.ShowReference();
        myScripture.DisplayScripture();

 
    }

}