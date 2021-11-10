using System;

namespace lesson3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] sea = new string[10, 10];
            string a;
            string b;
            while (true)
            {
                Console.WriteLine("Введите координаты кораблей (1 из 4х палуб, 2 из 3х палуб, 3 из 2х палуб и 4 из 1ой палубы): ");
                Console.Write("Выберет корябль (от 1 до 4): ");
                int s = Convert.ToInt32(Console.ReadLine());
                if (s == 4)
                {
                    Console.Write("Введите первую точку вашего коробля");
                    a = Console.ReadLine();
                    Console.Write("Введите вторую точку вашего коробля");
                    b = Console.ReadLine();
                    
                    Console.Write("Введите третью точку вашего коробля");
                    a = Console.ReadLine();
                    Console.Write("Введите чертвертую точку вашего коробля");
                    b = Console.ReadLine();

                }
            }
        }

        
    }
}
