using GeometricEXThroughInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Circle circle = new Circle(3);
        Console.WriteLine($"Área del Rectángulo: {rectangle.GetArea()}");
        Console.WriteLine($"Área del Círculo: {circle.GetArea()}");
    }
}