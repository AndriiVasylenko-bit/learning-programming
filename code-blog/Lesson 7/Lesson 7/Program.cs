using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую!!! Вы участвуете в опросе, наскольк вобшем большая аудтория на ютюбе у научпоп каналаов");
            List<int> NumberSubscribers = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                Console.Write("\nВведите количество ваших подписчиков: ");
                if (int.TryParse(Console.ReadLine(), out int Result))
                {
                    Console.WriteLine("\nСпасибо за участвие!");
                    NumberSubscribers.Add(Result);
                }
                else
                {
                    Console.WriteLine("\nВы ввели не коректное значение");
                    i = -1;
                    continue;
                }          
            }

            int Amount = 0;
            for (int j = 0; j < NumberSubscribers.Count; j++)
            {
                Amount = Amount + NumberSubscribers[j];
            }
            Console.WriteLine("\nОбщая аудитория у научпоп каналов:" + Amount);

            int Difference = 0;
            int o = 0;
            while (o < NumberSubscribers.Count)
            {
                Difference = Difference - NumberSubscribers[o];
                o++;
            }
            Console.WriteLine("Сколько ютюб может потерять зрителей:" + Difference);

            int Composition = 1;
            int d = 0;
            do
            {
                Composition = Composition * NumberSubscribers[d];
                d++;
            }
            while (d < NumberSubscribers.Count);
            Console.WriteLine("Потенсеальная аудитория:" + Composition + "\n");

            foreach(int Item in NumberSubscribers)
            {
                Console.WriteLine(Item);
            }

            Console.ReadKey();
        }
    }
}
