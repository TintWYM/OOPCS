using System.Collections.Generic;

namespace Workshop3;

class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>();

        shapes.Add(new Circle(5));
        shapes.Add(new Circle(7));
        shapes.Add(new Rectangle(2, 3));
        shapes.Add(new Rectangle(3, 4));

        DisplayInfo(shapes);
    }

    static void DisplayInfo(List<IShape> shapes)
    {
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Type: {shape.Type()}");
            Console.WriteLine($"Area: {shape.Area()}");
            Console.WriteLine($"Perimeter: {shape.Perimeter()}");
            Console.WriteLine("-------------------");
        }
    }
}

