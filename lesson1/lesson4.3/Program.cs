using System;

namespace lesson4._3
{
    class Program

    {
        enum Seasons
        {
            Зима = 1,
            Весна = 2,
            Лето = 3,
            Осень = 4
        }

        static void Main(string[] args)
        {
            int ok;
            bool control;
            string mon;
            Console.Write("Введите номер текущего месяца: ");
            do
            {
                mon = Console.ReadLine();
                control = int.TryParse(mon, out ok);
                if (ok < 1 || ok > 12)
                {
                    Console.Write("Ошибка: введите число от 1 до 12: ");
                    control = false;
                }

            }
            while (!control);
            checker(mon);
        }
        private static void checker(string c)
        {
            int mon;
            int seas = 0;
            mon = Convert.ToInt32(c);

            if (mon == 12 || mon == 1 || mon == 2)
            {
                seas = 1;
                Console.WriteLine($"Текущий сезон {(Seasons)seas}");
            }
            else if (mon == 3 || mon == 4 || mon == 5)
            {
                seas = 2;
                Console.WriteLine($"Текущий сезон {(Seasons)seas}");

            }
            else if (mon == 6 || mon == 7 || mon == 8)
            {
                seas = 3;
                Console.WriteLine($"Текущий сезон {(Seasons)seas}");

            }
            else if (mon == 9 || mon == 10 || mon == 11)
            {
                seas = 4;
                Console.WriteLine($"Текущий сезон {(Seasons)seas}");

            }


        }

    }
}
