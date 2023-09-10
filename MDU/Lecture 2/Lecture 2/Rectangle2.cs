using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

// Example.
namespace Lecture_2
{
    internal class Rectangle2
    {
        private double _a;
        private double _b;
        // Static fields.
        public static int Count;

        // Constructor without parameters.
        public Rectangle2()
        {
            Count++;
            _a = _b = 1;
        }

        public Rectangle2(double a)
        {
            _a = a;
            _b = 1;
        }

        //Constructors with parameters
        public Rectangle2(double a, double b) : this(a)
        {
            _b = b;
        }

        // Copy constructor.
        public Rectangle2(Rectangle2 rectangle2)
        {
            _a = rectangle2._a;
            _b = rectangle2._b;
        }

        //public Rectangle2(double a, double b)
        //{
        //    _a = a;
        //    _b = b;
        //}

        public string Print()
        {
            return $"a = {_a} b = {_b}";
        }

        public double Perimeter()
        {
            return 2 * (_a + _b);
        }

        public double Square()
        {
            return _a * _b;
        }

        public bool IsEqual(double a, double b)
        {
            return (_a == a && _b == b) || (_a == b && _b == a);
        }

        public static double Square(Rectangle2 r)
        {
            return r._a * r._b;
        }

        public void Scale(double scale)
        {
            _a *= scale;
            _b *= scale;
        }

        ~Rectangle2()
        {
            // Freeing dynamically allocated memory, closing files, etc.
        }
    }
}
