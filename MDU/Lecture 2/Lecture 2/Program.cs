using Lecture_2;

Rectangle2 rectangle = new Rectangle2();
Rectangle2 rectangle1 = new Rectangle2(3);
Rectangle2 rectangle2 = new Rectangle2(4, 5);
Rectangle2 rectangle3 = new Rectangle2(rectangle2);

// Access to class members.
Console.WriteLine("rectangle: {0} Perimeter: {1} Square: {2}", 
    rectangle.Print(), rectangle.Perimeter(), rectangle.Square());
Console.WriteLine("rectangle1: {0} Perimeter: {1} Square: {2}", 
    rectangle1.Print(), rectangle1.Perimeter(), rectangle1.Square());
Console.WriteLine("rectangle2: {0} Perimeter: {1} Square: {2}", 
    rectangle2.Print(), rectangle2.Perimeter(), rectangle2.Square());
Console.WriteLine("rectangle3: {0} Perimeter: {1} Square: {2}", 
    rectangle3.Print(), rectangle3.Perimeter(), rectangle3.Square());

// Static fields.
Console.WriteLine("Static fields {0}", Rectangle2.Count);

// Static methods.
Console.WriteLine("Static methods {0}", Rectangle2.Square(rectangle2));