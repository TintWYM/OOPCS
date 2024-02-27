namespace Workshop_Exception;

class Program
{
    static void Main(string[] args)
    {
        Triangle myTri = new Triangle(4, 2, 3);
        Console.WriteLine("Triangle 1 Perimeter is " + myTri.Perimeter());
        Console.WriteLine("Triangle 1 Area is " + myTri.Area());

        try
        {
            Triangle myTri1 = new Triangle(60, 2, 3);
            Console.WriteLine("Triangle 1 Perimeter is " + myTri1.Perimeter());
            Console.WriteLine("Triangle 1 Area is " + myTri1.Area());
        }
        catch (BadTriangle e) {
            Console.WriteLine("Bad " + e.Message);
        }
    }
}

