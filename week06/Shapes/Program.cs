using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 8));
        shapes.Add(new Circle("Green", 3));

        Console.WriteLine("---------- Shapes --------");

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Shape: {s.GetType().Name}");
            Console.WriteLine($"Clor: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea():0.00}");
            Console.WriteLine($"------------------------");
        }
    }

}