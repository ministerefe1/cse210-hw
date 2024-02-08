public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}

public class Circle : Shape
{
    private double Radius { get; set; }

    public Circle(string color) : base(color)
    {
        Radius = 5;
    }

    public override double GetArea()
    {
        return (3.14) * Math.Pow(Radius, 2);
    }
}

public class Square : Shape
{
    private double Length { get; set; }

    public Square(string color) : base(color)
    {
        Length = 6;
    }

    public override double GetArea()
    {
        return Math.Pow(Length, 2);
    }
}

public class Rectangle : Shape
{
    private double Height { get; set; }
    private double Width { get; set; }

    public Rectangle(string color) : base(color)
    {
        Height = 5.3;
        Width = 3.4;
    }

    public override double GetArea()
    {
        return Height * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle("Red");
        Console.WriteLine("Area: " + circle.GetArea() + ", Color: " + circle.GetColor());

        Shape square = new Square("Blue");
        Console.WriteLine("Area: " + square.GetArea() + ", Color: " + square.GetColor());

        Shape rectangle = new Rectangle("Green");
        Console.WriteLine("Area: " + rectangle.GetArea() + ", Color: " + rectangle.GetColor());
    }
}
