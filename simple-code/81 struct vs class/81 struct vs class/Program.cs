using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System;

namespace _81_struct_vs_class
{
    public class ClassPoint
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }

        ~ClassPoint() { }
    }

    interface IInterface
    {
        void Foo();
    }


    public struct StructPoint : IInterface
    {
        public int X { get; set; }
        public int Y { get; set; }

        public StructPoint(int x, int y)
        {
            X = X; Y = y;
        }

        public void Foo()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }

    public class Program
    {
        static void Foo(ClassPoint classPoint)
        {
            classPoint.X++;
            classPoint.Y++;
        }
        static void Bar(StructPoint structPoint)
        {
            structPoint.X++;
            structPoint.Y++;
        }

        public static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint();
            StructPoint structPoint = new StructPoint();

            Foo(classPoint);
            Bar(structPoint);
            IInterface myInterface = structPoint;

            ClassPoint classPoint1 = new ClassPoint { X = 2, Y = 3 };
            ClassPoint classPoint2 = new ClassPoint { X = 2, Y = 3 };

            bool classesAreEaqual = classPoint1.Equals(classPoint2);

            StructPoint structPoint1 = new StructPoint {  X = 2, Y = 3 };
            StructPoint structPoint2 = new StructPoint { X = 2, Y = 3 };

            bool structsAreEagual = structPoint1.Equals(structPoint2);
        }
    }
}
