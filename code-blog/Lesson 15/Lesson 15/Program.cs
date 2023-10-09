using System;//1:15:00

namespace Lesson_15
{

    //public delegate void Move();

    class Program
    {
        //public delegate int ValueTime(int valueSpeed);

        //public event Move Event;



        //public Action actionDelegate;

        //public int distance;
        //public int time;
        //public int speed;

        static void Main(string[] args)
        {
            #region delegate
            //// Объявление класса программы.
            //Program physics = new Program();

            //// Объявление с помощью присвоения и реализация делегата метода void.
            //Move move = physics.Move1;
            //move += physics.Move4;
            //move();

            //// Объявление с помощью передачи и реализация делегата метода void.
            //Console.WriteLine();
            //Move move2 = new Move(physics.Move1);
            //move2 += physics.Move4;
            //move2 -= physics.Move4;
            //move2.Invoke();

            //// Объединение одинаковых делегатов.
            //Console.WriteLine();
            //Move move3 = move + move2;
            //move3.Invoke();

            //// Объявление делегата с методом типа int.
            //var valueTime = new ValueTime(physics.Time);
            //valueTime += physics.Time;
            //valueTime += physics.Time;
            //valueTime += physics.Time;
            //valueTime += physics.Time;
            //valueTime += physics.Time;
            //Console.WriteLine(valueTime(2));

            //// Делегат который не возвращает не какого значения.
            //Action action = physics.Move1;
            //action();

            //// Делегат который возвращает значения int.
            //Action<int> action1 = physics.Move3;
            //action1(3);


            //// Делегат Predicate принимает указанное значение и возвращает True или false.
            //Predicate<int> predicate;
            ////public delegate bool Predicate<T>(int value);

            //// Первые 16 типов делегата Func это типы аргументов, а последний тип это возвращаемое значение.
            //Func<int, int> func =physics.Time;
            ////if (func != null)
            ////func(3);
            //func?.Invoke(3);

            ////public delegate int Func(string value);
            #endregion


            Person person = new Person
            {
                Name = "Андрей"
            };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("30.12.2021 06:19:01"));
            person.TakeTime(DateTime.Parse("30.12.2021 23:19:01"));


            Console.WriteLine(Sum(5, 5, Calc1));
            Console.WriteLine(Sum(5, 5, Calc2));
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} идет работать.");
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Человек пошел спать.");
        }


        private static int Sum(int a, int b, Func<int, int, int> calc)
        {
            return calc(a, b);
        }

        private static int Calc1(int i, int j)
        {
            return i * j;
        }

        private static int Calc2(int i, int j)
        {
            return i + j;
        }

        #region Method
        //public int Time(int valueSpeed)
        //{
        //    distance = 100;
        //    Console.WriteLine(time = distance / valueSpeed);

        //    return valueSpeed;
        //}

        //public void Move1()
        //{
        //    distance = 100;
        //    time = 50;

        //    Console.WriteLine(speed = distance / time);
        //}

        //public int Move2()
        //{
        //    distance = 100;
        //    time = 20;
        //    Console.WriteLine(speed = distance / time);

        //    return speed;
        //}

        //public void Move3(int i)
        //{
        //    distance = 100;
        //    time = 10;

        //    Console.WriteLine(speed = distance / time);
        //}

        //public void Move4()
        //{
        //    distance = 100;
        //    time = 5;

        //    Console.WriteLine(speed = distance / time);
        //}
        #endregion
    }
}
