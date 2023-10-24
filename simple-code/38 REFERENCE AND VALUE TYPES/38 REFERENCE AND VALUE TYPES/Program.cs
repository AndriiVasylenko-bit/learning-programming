internal class Program
{
    static void Foo(int value)
    {
        value = 5; //stak
    }

    static void Bar(int[] arr)
    {
        arr[0] = 5;
    }


    private static void Main(string[] args)
    {
        #region note
        ////Область видимости.
        //{
        //    int _a = 2; // Удалится valut type (stack).
        //    int[] _arr = new int[10]; // Удалится reference (heap) на наш масив, а память выделаная в stack будет занятна данными пока не вызовется сборшик мусора.
        //}

        ////stack - value
        //int a = 5;
        //System.Int32 b = 5;

        ////heap - reference
        //Random random = new Random();

        ////heap - reference
        //int[] arr = new int[10];
        ////Array

        ////stack - value
        ////ConsoleKey


        //// copy stack
        //{
        //    int __a = 5;
        //    int __b;
        //    __b = __a;
        //}
        //// copy heap
        //{
        //    int[] __arr = new int[10];// a (ref) - stack, a(DATA) - heap.
        //}

        //// copy stack -> heap
        //{
        //    int[] _a = new int[10]; // a(ref)-+
        //    int[] _b;               // b(ref)-+
        //    _b = _a;                //        +-> a(DATA)
        //}
        #endregion

        #region stack
        //int a = 1; //stack - value.
        //Foo(a); // Копируется значение из stack.
        //Console.WriteLine(a);
        #endregion

        int[] a = new int[1]; //heap - referens.
        a[0] = 1; //heap - referens.
        Bar(a); // копируется силка которая ссылается на heap.
        Console.WriteLine(a[0]);
    }

}