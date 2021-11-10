using System;

namespace lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] rev = { };

            string k;


            while (true)
            {
                Console.Write("Введите слово (для прекращения введите 'exit'): ");

                k = Console.ReadLine();

                if (k == "exit")
                {
                    break;
                }
                else
                {
                    rev = k.ToCharArray();
                }
                for (int i = rev.Length - 1; i > -1; i--)
                {
                    
                    if (i == 0)
                    {
                        ;
                        Console.WriteLine(rev[i] + "\n");
                    }
                    else
                    {
                        Console.Write(rev[i]);
                    }
                }
            }
            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
