using System;

namespace lesson4._3
{
    class Program

    {
        enum Seasons
        {
            Зима = 10,
            Весна = 20,
            Лето = 30,
            Осень = 40

        }
        enum Month
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь
        }
        static void Main(string[] args)
        {
            bool control;
            int ok;
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
        private static void checker (string c)
        {
            int mon;
            int seas = 0; 
            mon = Convert.ToInt32(c);

            if (mon == 12 || mon >= 1 || mon <=2)
            {
                seas = 10;
                Console.WriteLine($"Текущий месяц {(Month)mon}, Текущий сезон {(Seasons)seas}");
            }
            else if (mon >= 3 || mon <= 5)
            {
                seas = 20;
                Console.WriteLine($"Текущий месяц {(Month)mon}, Текущий сезон {(Seasons)seas}");

            }
            else if (mon >= 3 || mon <= 5)
            {
                seas = 30;
                Console.WriteLine($"Текущий месяц {(Month)mon}, Текущий сезон {(Seasons)seas}");

            }
            else if (mon >= 3 || mon <= 5)
            {
                seas = 40;
                Console.WriteLine($"Текущий месяц {(Month)mon}, Текущий сезон {(Seasons)seas}");

            }


        }

     }
}


