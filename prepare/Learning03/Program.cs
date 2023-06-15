using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        f.setUpperPart(1);
        f.SetLowerPart(1);

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction f1 = new Fraction();

        f1.setUpperPart(5);
        f1.SetLowerPart(2);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

    }
}

