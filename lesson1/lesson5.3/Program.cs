using System;
using System.IO;


namespace lesson5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа от 0 до 255: ");
            string hw2;
            string homework2;
            bool check;
            int result;

            homework2 = "homework2.bin";
            do
            {
                hw2 = Console.ReadLine();
                check = int.TryParse(hw2, out result);


                if (check)
                {

                    if (result < 0 || result > 255)
                    {
                        Console.Write("Некорректный ввод, ведите число от 0 до 255: ");
                    }

                }


                else
                
                    Console.Write("Некорректный ввод, ведите число от 0 до 255: ");
                
            }
            while (!check || result < 0 || result > 255);

            File.WriteAllText(homework2, hw2);

            File.AppendAllText(homework2, Environment.NewLine);

            string hwtext2 = File.ReadAllText(homework2);
            Console.Write("Вы ввели: ");
            Console.WriteLine(hwtext2);
        }
    }
}
