using System;
using System.IO;
using System.IO.Compression;

namespace lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string hw;
            string homework;
           
            homework = "homework.txt";
            hw = Console.ReadLine();
            File.WriteAllText(homework, hw);
           
            File.AppendAllText(homework, Environment.NewLine);

            string hwtext = File.ReadAllText(homework);
            Console.Write("Вы ввели: ");
            Console.WriteLine(hwtext);
        }
    }
}
