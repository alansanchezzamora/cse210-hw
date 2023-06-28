using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test0 = new Assignment("Alan Sanchez", "literature");
        Console.WriteLine(test0.GetStudentName());
        Console.WriteLine(test0.GetTopic());
        Console.WriteLine(test0.GetSummary());

        MathAssignment test1 = new MathAssignment("Alan Sánchez", "Math", "7.3", "8-30");
        Console.WriteLine(test1.GetSummary());
        Console.WriteLine(test1.GetHomeworkList());

        WrittingAssignment test2 = new WrittingAssignment("Alan sánchez", "Literature", "A long book");
        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetWritingInfo());
    }
}