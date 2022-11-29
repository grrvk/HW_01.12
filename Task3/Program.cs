
using System;

interface IRectangle
{
    double getArea();
}

class Rectangle : IRectangle
{
    private double Width;
    private double Height;
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double getArea()
    {
        return Width * Height;
    }
}

class Square : IRectangle
{
    private double Side;
    public Square(double side)
    {
        Side = side;
    }
    public double getArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(10);
        Console.WriteLine(square.getArea());
        Rectangle rect = new Rectangle(10, 5);
        Console.WriteLine(rect.getArea());
        Console.ReadKey();
    }
}