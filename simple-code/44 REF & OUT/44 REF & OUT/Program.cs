internal class Program
{
    static void Foo(ref int value)
    {
        value++;
        Console.WriteLine(value);
    }

    static void Bar(out int value)
    {
        value = 5;
        Console.WriteLine(value);
    }

    private static void Main(string[] args)
    {
        Bar(out int a);

        int b = 10;
        Foo(ref b);

        Console.WriteLine(a);

        Console.Write("Enter: ");
        string str = Console.ReadLine();
        int.TryParse(str, out int result);

        Console.WriteLine(result);
    }
}