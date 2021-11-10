using System;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phone = new string[5, 2]
            {                
                {"Василий" , " +79903601236" },
                {"Николай" ,  " nikolya98@mail.ru" },
                {"Дмитрий" ,  " +79036344575" },
                {"Денис" ,  " +79163355975, pupkov77@mail.ru" },
                {"Владимир" ,  " +79989463215" },
            };

            Console.WriteLine("Имя     Телефон, e-mail");

            for (int l = 0; l < phone.GetLength(0); l++)
            {
                for (int j = 0; j < phone.GetLength(1); j++)
                {
                    Console.Write(phone[l, j]);
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
