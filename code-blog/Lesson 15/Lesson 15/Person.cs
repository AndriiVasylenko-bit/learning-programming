﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Person
    {
        public event Action GoToSleep;
        public event EventHandler DoWork;

        public string Name { get; set; }

        public void TakeTime(DateTime now)
        {
            if(now.Hour <= 20)
            {
                GoToSleep?.Invoke();
            }
            else
            {
                var args = new EventArgs();
                DoWork?.Invoke(this, args);
            }
        }
    }
}
