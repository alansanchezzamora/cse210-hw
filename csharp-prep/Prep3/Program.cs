using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userMagic = Console.ReadLine();
        int number = int.Parse(userMagic);
        
        int guess = -1;
        
        while (guess != number)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.Write("What is your guess? ");
            }
            else
            { 
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it");

    }
}