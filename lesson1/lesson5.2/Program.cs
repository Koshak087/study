using System;
using System.IO;


namespace lesson5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = "datetime.txt";
            string [] date = { DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")};
            File.AppendAllLines(time, date);
            string[] datetime = File.ReadAllLines(time);
            for (int i = 0; i < datetime.Length; i++)
            {
                Console.WriteLine(datetime[i]);
            }
            
        }
    }
}
