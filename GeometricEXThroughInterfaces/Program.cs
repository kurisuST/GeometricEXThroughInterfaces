using GeometricEXThroughInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Rectangle rectangle2 = new Rectangle(7, 8);
        Triangle triangle = new Triangle(4, 2);
        Triangle triangle2 = new Triangle(7, 9);
        Circle circle = new Circle(3);
        Circle circle2 = new Circle(4);
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"2nd Rectangle Area: {rectangle2.GetArea()}");
        Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
        Console.WriteLine($"2nd Triangle Area: {triangle2.GetArea()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        Console.WriteLine($"2nd Circle Area: {circle2.GetArea()}");
    }
}