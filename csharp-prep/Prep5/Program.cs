using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string userName = GetName();
        int userNumber = GetNumber();
        int squared = SquareNumber(userNumber);

        PrintResult(userName, squared);

        static void Welcome()
        {
            Console.WriteLine("Welcome to the program");
        }
        static string GetName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        
        static int GetNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void PrintResult(string name, int square)
        {
            Console.Write($"{name}, the square of your number is {square}");
        }
    }
}