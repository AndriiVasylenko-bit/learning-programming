using System;
using System.Collections.Generic; // Библиотека для создания списка.

namespace Lesson_5
{
    //Перечисление.
    enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3,
        Autumn = 4
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Перечисление третий элемент: {Season.Summer}");
            Console.WriteLine($"Перечисление третий элемент: {(int)Season.Summer}");
            Console.WriteLine();

            // Колекции: масивы, списки. Перечисление.


            // Масив.
            string[] UserName = new string[5];

            UserName[0] = "Влад А4";
            UserName[1] = "Кобиков";
            UserName[2] = "Алишер";
            UserName[3] = "Сергей";
            UserName[4] = "Илон";

            Console.WriteLine($"Массив первый элемент: {UserName[0]}");

            Console.WriteLine();// Использую как переход на новою строку.
            

            // Список.
            List<decimal> MoneyReceivedByTheUser = new List<decimal>();

            MoneyReceivedByTheUser.Add(644.94M);
            MoneyReceivedByTheUser.Add(4.58M);
            MoneyReceivedByTheUser.Add(544.98M);
            MoneyReceivedByTheUser.Add(964.74M);
            MoneyReceivedByTheUser.Add(77998.04M);

            Console.WriteLine($"Список первый элемент: {MoneyReceivedByTheUser[0]}");

            // Выводим весь список с помощью цикла
            foreach (decimal item in MoneyReceivedByTheUser)
            {
                Console.WriteLine($"элемент списка: {item}");
            }



            Console.ReadKey();
        }
    }
}
