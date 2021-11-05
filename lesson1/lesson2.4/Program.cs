using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название магазина: ");
            string name = Console.ReadLine();
            long inn = 7710632615;
            Console.Write("Введите сумму покупок: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кассовый чек");
            Console.WriteLine(name + inn);
            Console.WriteLine($"Сумма покупок: {sum}р, НДС: {sum / 100 * 20}р");
            Console.Write($"Дата и время: {DateTime.Now}");
            Console.ReadLine();


        }
    }
}
