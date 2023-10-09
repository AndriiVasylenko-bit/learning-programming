// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Сылочний тип, хранистя в стеке
public class ClassPoint
{ 
    public int X {  get; set; }
    public int Y {  get; set; }

    public void Print()
    {
        Console.WriteLine($"X:{X}\tY:{Y}");
    }
}

// Значемый тип, хранится в куче
public struct StructPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"X:{X}\tY:{Y}");
    }
}