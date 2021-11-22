using System;
using System.Diagnostics;

namespace lesson6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var processess = Process.GetProcesses();

            foreach (var process in processess)
            {
                Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName}, {nameof(Process.Id)}: {process.Id}");
            }

            Console.Write("Введите ID или название процееса: ");

            var proc = Console.ReadLine();
            int kill1;
            bool cheker = int.TryParse(proc, out int result);

            if (cheker)
            {
                kill1 = result;
                var kill = Process.GetProcessById(kill1);
                kill.Kill();
            }
            else if (!cheker)
            {
                foreach (var kill in Process.GetProcessesByName($"{proc}"))
                {
                    kill.Kill();
                }

            }
            Console.WriteLine($"Вы сняли задачу с процесса {proc}");


        }
    }
}
