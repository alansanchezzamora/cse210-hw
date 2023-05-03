using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}.");
        
        if (grade >= 70)
        {   
            Console.WriteLine("Congratulations");
        }
        else
        {
            Console.WriteLine("Try harder next time");
        }
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

    }
}