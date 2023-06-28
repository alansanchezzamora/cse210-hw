using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Si me amais guardad mis mandamientos";
        string referenceText = "Juan 14:25";
        Scripture myScripture = new Scripture(scriptureText);
        Reference myReference = new Reference(referenceText);
                                
        bool answer = false;
        while (myScripture.IsCompletelyHidden(myScripture.GetScripture())  && answer == true ){
            Console.Clear();
            myReference.ShowReference();
            myScripture.DisplayScripture();
            Console.Write("\n\nPress enter to hide words, or quit to exit ");
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