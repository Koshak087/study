using System;
using System.Collections.Generic;

namespace lesson4._2
{
    class Program
    {
        private static void Main(string[] args)
        {
            string u = " ";
            bool check;
            int sum = 0;
            Console.WriteLine("Введите числа через пробле");
            string i = Console.ReadLine();
            string[] t = i.Split(' ');
            for (int j = 0; j < t.Length; j++)
            {
            
                check = int.TryParse(t[j], out int result);
                
                    
                    if (t[j] != u & check == true)
                    {
                        sum += Convert.ToInt32(t[j]);
                    }
                else
                {
                    continue;
                } 
                
        }
            Console.WriteLine("{0}", sum);



        }
    }
}
