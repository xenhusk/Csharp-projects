using System;

// Struct example
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

// Class example
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}

// Inheritance
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing circle with radius {radius}");
    }
}

// Abstract class example
public abstract class Polygon
{
    public abstract double GetArea();
}

// Polymorphism with inheritance
public class Rectangle : Polygon
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

// Interface example
public interface IDrawable
{
    void Draw();
}

// Implementing interface
public class Line : IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Drawing line");
    }
}

class Program
{
    static void Main()
    {
        // Struct usage
        Point point = new Point(5, 10);
        point.Display();

        // Class, constructor, object usage
        Circle circle = new Circle(5);
        circle.Draw();

        // Polymorphism example
        Shape shape = new Circle(3);
        shape.Draw();

        Polygon rectangle = new Rectangle(4, 5);
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());

        // Interface usage
        IDrawable line = new Line();
        line.Draw();
    }
}
