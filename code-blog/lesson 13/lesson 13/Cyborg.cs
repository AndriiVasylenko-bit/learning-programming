using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13
{
    public class Cyborg : ICar, IPerson
    {
        public int speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Create()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distnace)
        {
            return distnace / 100;
        }

        int IPerson.Move(int distance)
        {
            return distance / 15;
        }
    }
}
