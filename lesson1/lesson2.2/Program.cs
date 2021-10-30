using System;

namespace lesson2._2
{
    class Program

    {
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
            Console.Write("Введите маскимальную температуру за текущие сутки:");
            double tmax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную температуру за текущие сутки:");
            double tmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Средняя температура за сегодня: " + (tmax + tmin) / 2);
            Console.Write("Введите номер текущего месяца: ");

            int mon;
            do
            {
                mon = Convert.ToInt32(Console.ReadLine());
                if (mon < 1 || mon > 12)
                {
                    Console.Write("Ошибка ввода, введите корректный номер месяца: ");
                }
            }
            while (mon < 1 || mon > 12);
            
            if (mon == Convert.ToInt32((Month)mon) && (tmax + tmin) / 2 > 0 || mon == Convert.ToInt32((Month)1 | (Month)2 | (Month)12))
                {
                    Console.WriteLine($"Текущий месяц {(Month)mon}");
                    Console.WriteLine("Дождливая зима");

                }
            else
                {
                    Console.WriteLine($"Текущий месяц {(Month)mon}");
                }

            Console.ReadLine();
        }
    }
}




