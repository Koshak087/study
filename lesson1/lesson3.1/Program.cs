using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон двумерного массива: ");
            int a = int.Parse(Console.ReadLine());
            int[,] mas = new int[a, a];
            int k = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        mas[i, j] = k;
                        Console.Write($"{mas[i, j]}");
                    }
                    else
                    {
                        Console.Write($"{mas[i, j]}");
                    }                                         
                }
                k++;
                Console.WriteLine();
            }

        }
    }
}


