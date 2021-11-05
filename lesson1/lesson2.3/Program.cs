using System;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число не четное.");
            }
            Console.ReadLine();
        }
    }
}
