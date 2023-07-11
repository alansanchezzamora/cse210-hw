using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("5th Av", "New York", "NY", "USA");
        Lectures lecture1 = new Lectures("CSE 210 - 101","Introduction to programming with classes","07/11/2023","2:00PM",address1,"Brother Poulson",500);
        //Console.WriteLine(lecture1.ShortDescription());
        Console.WriteLine(lecture1.DisplayFullDetails());
        //Console.WriteLine(lecture1.DisplayShortDescription());

        Address address2 = new Address("Shrute Street", "Scranton", "PA", "USA");
        Receptions reception1 = new Receptions("Dwight Wedding", "Dwight Shrute is getting married to Angela Martin","07/12/2023", "6:00PM", address2, "mscott@dundermifflin.com");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(reception1.DisplayFullDetails());

        Address address3 = new Address("Main Street", "Aspen", "CO", "USA");
        Outdoors outdoors1 = new Outdoors("Close of the mountain Party", "Snow end of season party to close the mountain", "04/15/2023","4:00PM",address3,"60°F");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(outdoors1.DisplayFullDetails());
        
    }
}