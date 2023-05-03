using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        int newNumber = -1;

        while (newNumber != 0) 
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);
        }

        int suma = 0;

        foreach (int num in numbers)
        {
            suma += num ;
        }
        Console.WriteLine($"The sum is {suma}");

        float average = 0;

        average = suma / (numbers.Count-1);
        Console.WriteLine($"The average is {average}");

        Console.WriteLine($"The largest number is {numbers.Max()}");
    }
}