using System;

namespace lesson4._1
{
    class Program
    {

        static void Main (string[] args)
        {
                GetFullName("Иван", "Иванов", "Ивановчи");
                GetFullName("Петр", "Петров", "Петрович");
                GetFullName("Семён", "Семёнов", "Семёнович");
                GetFullName("Кирилл", "Кириллов", "Кириллович");
          

        }       
        private static void GetFullName(string firstName, string lastName, string patronomic)
        {
            {
                Console.WriteLine($"{lastName} {firstName} {patronomic}");
            }
            
        }
    }
}
