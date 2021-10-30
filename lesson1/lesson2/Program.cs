using System;

namespace lesson2
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
        }
    }
}
