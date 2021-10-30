using System;

namespace lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите маскимальную температуру за текущие сутки:");
            double tmax = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную температуру за текущие сутки:");
            double tmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Средняя температура за сегодня: " + (tmax + tmin) / 2);
            
            Console.Write("Введите номер текущего месяца: ");
            int mon = Convert.ToInt32(Console.ReadLine());
            switch (mon)
            {
                case 1:
                    Console.WriteLine("Сейчас январь.");
                    if (tmax+tmin/2 > 0)
                    {
                        Console.WriteLine("Доджливая Зима");
                    }
                    break;
                case 2:
                    Console.WriteLine("Сейчас февраль.");
                    if (tmax + tmin / 2 > 0)
                    {
                        Console.WriteLine("Доджливая Зима");
                    }
                    break;
                case 3:
                    Console.WriteLine("Сейчас март.");
                    break;
                case 4:
                    Console.WriteLine("Сейчас апрель.");
                    break;
                case 5:
                    Console.WriteLine("Сейчас май.");
                    break;
                case 6:
                    Console.WriteLine("Сейчас июнь.");
                    break;
                case 7:
                    Console.WriteLine("Сейчас июль.");
                    break;
                case 8:
                    Console.WriteLine("Сейчас август.");
                    break;
                case 9:
                    Console.WriteLine("Сейчас сентябрь.");
                    break;
                case 10:
                    Console.WriteLine("Сейчас октябрь.");
                    break;
                case 11:
                    Console.WriteLine("Сейчас ноябрь.");
                    break;
                case 12:
                    Console.WriteLine("Сейчас декабрь.");
                    if (tmax + tmin / 2 > 0)
                    {
                        Console.WriteLine("Доджливая Зима");
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}



