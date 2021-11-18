using System;
using System.Text.Json;

namespace lesson5._5
{
    /// <summary>
    /// Здание
    /// </summary>
    public class ToDo
    {
        public bool IsDone { get; set; }

        public string Title { get; set; }

        public ToDo(string title, bool isdone)
        {
            Title = title;
            IsDone = isdone;
        }


        public void Work(string title, char isdone)
        {
            
        }
    }

}
