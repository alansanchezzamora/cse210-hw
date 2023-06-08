using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> myList = new List<string>()
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango",
            "Grape"
        };

        Random random = new Random();
        int randomIndex = random.Next(myList.Count);
        string randomElement = myList[randomIndex];

        Console.WriteLine("Randomly selected element: " + randomElement);
    }
}