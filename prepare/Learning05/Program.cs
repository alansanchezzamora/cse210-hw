using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> _shapes = new List<Shape>();
        Square testSquare = new Square("white", 5.00);
        Circle testCircle = new Circle("Red", 5.00);
        Rectangle testRectangle = new Rectangle("Blue",2.00,5.00);
        _shapes.Add(testCircle);
        _shapes.Add(testSquare);
        _shapes.Add(testRectangle);

        foreach(Shape s in _shapes){
            Console.WriteLine($"Shape: {s} Area: {s.GetArea()} Color: {s.GetColor()}");
        }
    }
}