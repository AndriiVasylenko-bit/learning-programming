// Ключевое слово ref.
// Передача аргументов по ссылке.
// Ссылочные локальные переменные.
// Возращаемые ссылочные значенния.
internal class Program
{
    // Возращаемые ссылочные значенния.
    static ref int Foo(int[] numbers)
    {
        return ref numbers[0];
    }

    // Reference type 2.
    //static void Bar(ref int[] arr)
    //{
    //    //myArray[0] = -5;
    //    //arr = null;
    //    arr = new int[10];
    //}

    //struct MyStruct
    //{
    //    public int a;
    //    public double b;
    //    public float c;
    //}

    //class MyClass
    //{
    //    public int a;
    //    public double b;
    //    public float c;
    //}

    // Reference type.
    //static void Foo(MyClass myClass)
    //{
    //    myClass.a = -5;
    //}

    // Используется для изменения структур.
    //static void Foo(ref MyStruct myStruct)
    //{
    //    myStruct.a = -5;
    //}

    // Нарушает принцыпи SOLID.
    //static void Foo(ref int a, ref int b, ref int c, ref int d)
    //{
    //    a = -5;
    //}

    //static void Foo(ref int a)
    //{
    //    a = -5;
    //}

    private static void Main(string[] args)
    {
        //int a = 2;
        //Foo(ref a);
        //Console.WriteLine(a);

        //// Value type.
        //MyStruct myStruct = new MyStruct();
        //Foo(ref myStruct);

        //// Reference type.
        //MyClass myClass = new MyClass();
        //Foo(myClass);

        //// Reference type 2.
        //int[] myArray = { 1, 4, 6 };
        //Bar(ref myArray);

        //// Ссылочные локальные переменные.
        //int[] arr = { 2, 6, 1 };
        //ref int b = ref arr[0];
        //b = -5;

        // Возращаемые ссылочные значенния.
        int[] arr = { 2, 6, 1 };
        ref int b = ref Foo(arr);
        b = -5;
    }
}
