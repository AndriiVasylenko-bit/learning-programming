
# Struct vs Class
## Reference type, is in the stack

    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }

## Value type, is in the heap

    public struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }

**������ �� ������ ������� ��� � ����������� �����:**
[![image.png](https://i.postimg.cc/sf9VBkzw/image.png)](https://postimg.cc/3WNMVbdv)
��� ���������� ��-�� ���� ��� ����� ������ *point* � ������ *ClassTest()* ��������� ���������� ������� ������ (�������� ���� ����� ������� ��� ������). ����� �������� ����� � ����������� ���� ������� ������������ ��� �������� �������. ����� �������� ������� ������, ����� ��������������� ������ ���� ��������� ���� �� �� ����������, ��� � ��������� ������ ����� ���������:

    public void ClassTest()
    {
        ClassPoint point = new ClassPoint();
        point.X = 1;
        point.Y = 2;
        var result = point.X = point.Y;
    }

� ������ �� *class*, ���� *struct* ��� ������ ������� ������� ������ ������ �� ���������. ������ ��� ��� ������ �������� � *stack*, ����� *StructTest()* � ������� ������������ *struct* ��������� �������:

    public void StructTest()
    {
        StructPoint point = new StructPoint();
        point.X = 1;
        point.Y = 2;
        var result = point.X = point.Y;
    }

## ������������� Struct � Class:
**� ������������ ������� ���� ������������ structs, � �� classes:**
 1. �� ���������� ������ � ����������� *heap*.
 2. �� ����������� ������� ������.
 3. ��� �������� �������.
 
**� � ��������� ������� classes ����� �������� ������� ��� structs:** 
1. ���� *struct* ���������� �� ��������, � *class* �� *refrens* :[![image.png](https://i.postimg.cc/kX0Xh4zs/image.png)](https://postimg.cc/jLhbDssn)

Error CS0165  Use of unassigned local variable 'structPoint1':

    StructPoint structPoint1;
	Console.WriteLine(structPoint1.X1);

Error CS0165  Use of unassigned local variable 'a':

    int a;
    Console.WriteLine(a);

���� ��� ����� �������� ����������� ��� ����������:

	int b = new int();
	Console.WriteLine(b);

[![image.png](https://i.postimg.cc/yN9Yjq7D/image.png)](https://postimg.cc/R3SBCD6m)
����� ��� *structs*���������� �� ��������, �� ������� �������� �������� *stack* ���������� � ����� ��������� � ������.

������:
-
[![image.png](https://i.postimg.cc/Y9g0rb8m/image.png)](https://postimg.cc/zbz8pwsJ)
*Struct MyStruct* ��������� *class MyCalss* ��-�� ���������� ������. �� ���� ��� ���������� 10 ����� � *class* � ��� ���������� 10 ������� � *struct*:

    struct MyStruct
    {
        public decimal MyProperty1 { get; set; }
        public decimal MyProperty2 { get; set; }
        public decimal MyProperty3 { get; set; }
        public decimal MyProperty4 { get; set; }
        public decimal MyProperty5 { get; set; }
        public decimal MyProperty6 { get; set; }
        public decimal MyProperty7 { get; set; }
        public decimal MyProperty8 { get; set; }
        public decimal MyProperty9 { get; set; }
        public decimal MyProperty10 { get; set; }
    }

    class MyCalss
    {
        public decimal MyProperty1 { get; set; }
        public decimal MyProperty2 { get; set; }
        public decimal MyProperty3 { get; set; }
        public decimal MyProperty4 { get; set; }
        public decimal MyProperty5 { get; set; }
        public decimal MyProperty6 { get; set; }
        public decimal MyProperty7 { get; set; }
        public decimal MyProperty8 { get; set; }
        public decimal MyProperty9 { get; set; }
        public decimal MyProperty10 { get; set; }
    }
������� ����������� � ���, ����� ������� *struct* �� ����� ������ ��������� � �������� ��������� � ����� � �� �� ����� �� ��������� � *class*:

    private void Foo(MyCalss myCalss)
    {
        var t = myCalss.MyProperty1 + myCalss.MyProperty2;
    }
    
    private void Bar(MyStruct myStruct)
    {
        var t = myStruct.MyProperty1 + myStruct.MyProperty2;
    }

����� �������� *struct*, ��� �������� ��� �������� � ����� ���������. ��� ������ ������� ��� ������ ��� ����� ������������. � *class* ����� �������� � �������� ��� ������ ��� ��, �� ����������, � ��������� �� *reference* �� ����������� *heep*.

���� ����� ����� �������� � ����������� �������������� � �������������� ��������� *ref* ��� *in*:
[![image.png](https://i.postimg.cc/h4wgQ91z/image.png)](https://postimg.cc/0rphLK3P)

     private void Bar(in MyStruct myStruct)
     {
         var t = myStruct.MyProperty1 + myStruct.MyProperty2;
     }
     ...
     Bar(in _myStruct);



2. *Struct*�� ���� ������������ ������������, �����������:

������:
-
Error	CS0527	Type 'MyClass' in interface list is not an interface

	class MyClass { }
    public struct StructPoint : MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }

Error	CS0527	Type 'MyStruct' in interface list is not an interface:
    
    struct MyStruct { }
    public struct StructPoint : MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
    
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
� ���� ���������� ������� ��������� � ������������ � *struct* ���� �� ��������. � ����� ��� ����������� �������������� *Finalize*:

    ~ClassPoint() { }
    
Error	CS8983	A 'struct' with field initializers must include an explicitly declared constructor:

    public struct StructPoint
    {
         public int X { get; set; } = 0;
         public int Y { get; set; } = 0;
    }
    
� *struct* ����������� ����������� �������� ������� *struct* ��� ����������, ��� ������� ������������:

    public struct StructPoint : IInterface
    {
        public int X { get; set; }
        public int Y { get; set; }

        public StructPoint(int x, int y)
        {
            X = X; Y = y;
        }
    }
    ...
    StructPoint structPoint = new StructPoint();
����� *Equals* ���������� �� ��������, � *reference*:
[![Screenshot-2023-10-20-151340.png](https://i.postimg.cc/WzSmcyrs/Screenshot-2023-10-20-151340.png)](https://postimg.cc/YLGL1bbP)

*Array* �� ����� ���� ��� *reference type* � ��������� ������� �� ��������� � �������� ��������� *Array*. ������� ������ ������������ � ����������� *heep*. ��� �� ���� *Array* ����������� ������� � ����������� ������, ��� ��������� ������ �������� ������ � ��������� *Array* ������ ���� ����� ������ *Array* � ������� ������� �� ������ ���������� ���� � ����������� �� ���� ������� ���� �������� ������ ������� *Array*.
[![image.png](https://i.postimg.cc/j2qNch1m/image.png)](https://postimg.cc/xJ7cTLn3)

*Struct* � ���� ������� ����������� ������ ������� �������� ���� *Arrey* ����� ������ ��������, ������ �������� ������� ��������� ��������, ��������� �������� ������ *Structs*:

    [Benchmark]
    public void StructArreyTest()
    {
        StructPoint[] structPoints = new StructPoint[100];
        for (int i = 0; i < structPoints.Length; i++)
        {
            structPoints[i] = new StructPoint();
        }
    }
����� ��������� *array structs*, �� ���������� ������ � ����������� *heep* ���� ��������, ��� ��� *array* � ���� ����� �� ��� ������ ������ ������������� �������� ������ � ������ �������,  ������ ��� *array* �� *value type*.

*Class*�� � *array*��������� �� �������� ������, � *reference* �� ������, � ����������� ������ ��������� ��� ��������, ������� ������� �� *reference*. �� ������ ������� ����������� ������, ��� ����� �������� ������, ������� ����������� �������� *classes*. ������� ����� �� ������������ �������:

    [Benchmark]
    public void ClassArreyTest()
    {
        ClassPoint[] classPoints = new ClassPoint[100];
        for (int i = 0; i < classPoints.Length; i++)
        {
            classPoints[i] = new ClassPoint();
        }
    }
��, ��-������, � heap ��������� *array*, �� ����� ��������� ������� *classes*, � �������� *array*�������� �� ������, � *reference* �� ������ ������� ��� �� ������ ���� ��������� � ����������� ����. ������ ��� ����� ��������� ������ *class*� *array*, ���������� ������ ����� ���� ������� ���������� ������ � ����������� heap.

�����
 1. *Struct* ��� ����������� �� ������ ����������� ������ �� *class*. �� ������� ����������� � ���, ��� ��� �������� � ����������� ������.
 2. *Struct* ��� *value type*, � *class* ��� *reference type,*.
 3. *Struct* � ������� �� *class* �� ��������� ����������� ������ ������������, �������������� � ���� ���������� ������� ������������ ��� ������������, �������� ����� ������������ ������� � ��� *structs*�� ����� ��������, ������ ��� *struct* �� ����� � ������������.
 4. *Structs* ����� ������������ ����� ���������� ����������� �����-�� *type* ������ �� �����-�� ����������� *types* ������� ��������� ������ ���� ������.
 5. ������, ������� ��������������, � ���� *stracts* �� ������� �� ����� �������� ���������� ����� � �������.
 6. ���� ����� ����� ������������ *struct* � ������� ����������� ����� � ������� � �� ����� ������������ *in* ���� *ref* ��� �������� *structs*� �����.
 7. ������� �������� ���������� *structs*�������� Vector  �� ������ Unity.
 8. *Struct* �� ���� ������� ��� ����������� *type* int, double, float, bool.
 9. ������������� *structs* �������� �������� ����� ������ ������ �� ��������� ������, ������� ������� �������� � ���������������� ���������.
 10. *Structs*����� ���������� � ����������� ����.
 11. ��������, ��� ��� ���� ������������ � *Array*. ����� � ����� �� ���� ���� ���� ���� ��� *unboxing*, � *boxing* � ��-�� ����� �������� *struct* ����� ��������� � ����������� ����.