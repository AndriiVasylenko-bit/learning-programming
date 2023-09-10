using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    class BMWSeven : ICar, IComparable
    {
        public int speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public int Move(int distnace)
        {
            return distnace / 100;
        }
    }
}
