using System;
namespace lesson2._5
    {
        class Program
        {
            [Flags]
            public enum Days
            {
                Понедельник = 1,
                Вторник = 2,
                Среда = 3,
                Четверг = 4,
                Пятница = 5,
                Суббота = 6,
                Воскресенье = 7
            }

            static void Main(string[] args)
            {
                Console.WriteLine($"Офис 1 работает c: {(Days)2} по: {(Days)7}");
                Console.WriteLine($"Офис 1 работает c: {(Days)1} по: {(Days)7}");
            Console.ReadLine();
            }
        }
    }
