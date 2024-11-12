using System;

interface IShape
{
    float GetArea();
}

class Rectangle : IShape
{
    public float Width { get; set; }
    public float Height { get; set; }

    public float GetArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : IShape
{
    public float Width { get; set; }

    public float GetArea()
    {
        return Width * Width;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Square rect = new Square();
        rect.Width = 5;

        Console.WriteLine(rect.GetArea());
        //Відповідь 100? Що не так???
        Console.ReadKey();
    }
}
// Liskov Substitution Principle!!!