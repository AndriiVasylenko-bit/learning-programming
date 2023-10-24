using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using _81_struct_vs_class;


namespace Benchmark
{
    [MemoryDiagnoser]
    public class Benchmark_1
    {
        [Benchmark]
        public void StructTest()
        {
            StructPoint point = new StructPoint();
            point.X = 1;
            point.Y = 2;
            var result = point.X = point.Y;
        }
        [Benchmark]
        public void ClassTest()
        {
            ClassPoint point = new ClassPoint();
            point.X = 1;
            point.Y = 2;
            var result = point.X = point.Y;
        }
    }

    [MemoryDiagnoser]
    public class Benchmark_2
    {
        [Benchmark]
        public void StructArreyTest()
        {
            StructPoint[] structPoints = new StructPoint[100];
            for (int i = 0; i < structPoints.Length; i++)
            {
                structPoints[i] = new StructPoint();
            }
        }
        [Benchmark]
        public void ClassArreyTest()
        {
            ClassPoint[] classPoints = new ClassPoint[100];
            for (int i = 0; i < classPoints.Length; i++)
            {
                classPoints[i] = new ClassPoint();
            }
        }
    }

    [MemoryDiagnoser]
    public class Benchmark_3
    {
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

        private MyStruct _myStruct = new MyStruct();
        private MyCalss _myClass = new MyCalss();

        private void Foo(MyCalss myCalss)
        {
            var t = myCalss.MyProperty1 + myCalss.MyProperty2;
        }
        private void Bar(MyStruct myStruct)
        {
            var t = myStruct.MyProperty1 + myStruct.MyProperty2;
        }
        private void Bar(in MyStruct myStruct)
        {
            var t = myStruct.MyProperty1 + myStruct.MyProperty2;
        }

        [Benchmark]
        public void StructTestIn()
        {
            Bar(in _myStruct);
        }
        [Benchmark]
        public void StructTest()
        {
            Bar(_myStruct);
        }
        [Benchmark]
        public void ClassTest()
        {
            Foo(_myClass);
        }
    }
}

[MemoryDiagnoser]
public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
