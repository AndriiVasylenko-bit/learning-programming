
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

**Работа со стеком быстрее чем с управляемой кучей:**
[![image.png](https://i.postimg.cc/sf9VBkzw/image.png)](https://postimg.cc/3WNMVbdv)
Это происходит из-за того что когда объект *point* в методе *ClassTest()* отработал вызываться сборщик мусора (которому тоже нужны ресурсы для работы). Чтобы очистить место в управляемой куче которую использовали для создания объекта. Когда работает сборщик мусора, тогда останавливается робота всей программы пока он не отработает, что и замедляет работу нашей программы:

    public void ClassTest()
    {
        ClassPoint point = new ClassPoint();
        point.X = 1;
        point.Y = 2;
        var result = point.X = point.Y;
    }

В отличи от *class*, есть *struct* для работы которой сборщик мусора вообще не требуется. Потому что все данные хранятся в *stack*, метод *StructTest()* в котором используется *struct* отработал быстрее:

    public void StructTest()
    {
        StructPoint point = new StructPoint();
        point.X = 1;
        point.Y = 2;
        var result = point.X = point.Y;
    }

## Использование Struct и Class:
**В определенных случаях луче использовать structs, а не classes:**
 1. Не используем память в управляемой *heap*.
 2. Не задействуем сборщик мусора.
 3. Код работает быстрее.
 
**А в некоторых случаях classes могут работать быстрее чем structs:** 
1. Ведь *struct* передается по значению, а *class* по *refrens* :[![image.png](https://i.postimg.cc/kX0Xh4zs/image.png)](https://postimg.cc/jLhbDssn)

Error CS0165  Use of unassigned local variable 'structPoint1':

    StructPoint structPoint1;
	Console.WriteLine(structPoint1.X1);

Error CS0165  Use of unassigned local variable 'a':

    int a;
    Console.WriteLine(a);

Учтём что нужно вызывать конструктор без параметров:

	int b = new int();
	Console.WriteLine(b);

[![image.png](https://i.postimg.cc/yN9Yjq7D/image.png)](https://postimg.cc/R3SBCD6m)
Видим что *structs*передаются по значению, из каждого свойства значения *stack* копируются в новый экземпляр в методе.

Пример:
-
[![image.png](https://i.postimg.cc/Y9g0rb8m/image.png)](https://postimg.cc/zbz8pwsJ)
*Struct MyStruct* проиграла *class MyCalss* из-за количества данных. То есть при количестве 10 полей в *class* и при количестве 10 свойств в *struct*:

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
Разница заключается в том, каким образом *struct* со всеми полями предается в качестве параметра в метод и то же самое по отношению к *class*:

    private void Foo(MyCalss myCalss)
    {
        var t = myCalss.MyProperty1 + myCalss.MyProperty2;
    }
    
    private void Bar(MyStruct myStruct)
    {
        var t = myStruct.MyProperty1 + myStruct.MyProperty2;
    }

Когда передаем *struct*, она копирует все свойства в новый экземпляр. Чем больше свойств тем дольше она будет копироваться. У *class* такой проблемы в принципе нет потому что он, не копируется, а предается по *reference* из управляемой *heep*.

Есть нюанс можно бороться с замедлением быстродействия с использованием оператора *ref* или *in*:
[![image.png](https://i.postimg.cc/h4wgQ91z/image.png)](https://postimg.cc/0rphLK3P)

     private void Bar(in MyStruct myStruct)
     {
         var t = myStruct.MyProperty1 + myStruct.MyProperty2;
     }
     ...
     Bar(in _myStruct);



2. *Struct*не умет использовать наследование, полиморфизм:

Пример:
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
И весь функционал который относится к наследованию в *struct* тоже не возможен. И также нет возможности переопределять *Finalize*:

    ~ClassPoint() { }
    
Error	CS8983	A 'struct' with field initializers must include an explicitly declared constructor:

    public struct StructPoint
    {
         public int X { get; set; } = 0;
         public int Y { get; set; } = 0;
    }
    
В *struct* сохраняется возможность создания объекта *struct* без параметров, при наличии конструктора:

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
Метод *Equals* сравнивает не значения, а *reference*:
[![Screenshot-2023-10-20-151340.png](https://i.postimg.cc/WzSmcyrs/Screenshot-2023-10-20-151340.png)](https://postimg.cc/YLGL1bbP)

*Array* на самом деле это *reference type* и структуры которые мы добавляем в качестве элементов *Array*. Который просто расположений в управляемой *heep*. Сам по себе *Array* непрерывную область в оперативной памяти, что позволяет быстро получать доступ к элементам *Array* просто зная адрес самого *Array* с помощью отступа на нужное количество байт в зависимости от того сколько байт занимает каждый элемент *Array*.
[![image.png](https://i.postimg.cc/j2qNch1m/image.png)](https://postimg.cc/xJ7cTLn3)

*Struct* в этой области оперативной памяти которую занимает весь *Arrey* через каждый интервал, которы отвечает размеру реального элемента, находятся реальные данные *Structs*:

    [Benchmark]
    public void StructArreyTest()
    {
        StructPoint[] structPoints = new StructPoint[100];
        for (int i = 0; i < structPoints.Length; i++)
        {
            structPoints[i] = new StructPoint();
        }
    }
Когда создается *array structs*, то выделяется память в управляемой *heep* лишь единожды, под сам *array* и дале когда он уже создан просто присваиваются реальные данные в каждый элемент,  потому что *array* из *value type*.

*Class*то в *array*находятся не реальные данные, а *reference* на данные, в оперативной памяти находятся все элементы, которые состоят из *reference*. На разные области оперативной памяти, где лежат реальные данные, которые принадлежат объектам *classes*. Которые лежат по определённому индексу:

    [Benchmark]
    public void ClassArreyTest()
    {
        ClassPoint[] classPoints = new ClassPoint[100];
        for (int i = 0; i < classPoints.Length; i++)
        {
            classPoints[i] = new ClassPoint();
        }
    }
То, во-первых, в heap создается *array*, но когда создаются объекты *classes*, в элементы *array*помещаем не данные, а *reference* на данные которые так же должны быть размещены в управляемой куче. Каждый раз когда размещаем объект *class*в *array*, необходимо пройти через весь процесс размещения данных в управляемой heap.

Итоги
 1. *Struct* это конструкция по своему функционалу похожа на *class*. Но разница заключается в том, как она хранится в оперативной памяти.
 2. *Struct* это *value type*, а *class* это *reference type,*.
 3. *Struct* в отличие от *class* не позволяет реализовать логику наследования, соответственно и весь функционал который используются при наследовании, ключевые слова модификаторы доступа — для *structs*не имеют значения, потому что *struct* не может в наследование.
 4. *Structs* лучше использовать когда необходимо представить какой-то *type* данных из каких-то примитивных *types* которые логически должны быть вместе.
 5. Объект, который представляется, в виде *stracts* не состоит из очень большого количества полей и свойств.
 6. Если очень нужно использовать *struct* с большим количеством полей и свойств – то нужно использовать *in* либо *ref* при передаче *structs*в метод.
 7. Хорошим примером реализации *structs*является Vector  из движка Unity.
 8. *Struct* чу чуть сложнее чем примитивный *type* int, double, float, bool.
 9. Использование *structs* помогает избежать более частой работы со сборщиком мусора, который требует ресурсов и приостанавливает программу.
 10. *Structs*могут находиться в управляемой куче.
 11. Например, как это было представлено с *Array*. Также в языке си шарп есть така вещь как *unboxing*, а *boxing* — из-за этого процесса *struct* может храниться в управляемой куче.