using System;
using System.Configuration;
using System.Collections.Specialized;

namespace lesson8._1
{
    class MyOptions
    {
        public string Title { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            bool check = true;
            string age;
            string prof;
            Console.WriteLine($"{Properties.Resources.hello}");
            
            Configuration roamig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = roamig.FilePath };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            if (ConfigurationManager.AppSettings["username"] == null)
            {
                Console.WriteLine("Введите имя пользователя:");
                config.AppSettings.Settings.Add("username", Console.ReadLine());
                Console.WriteLine("Введите Ваш возраст:");
                do
                {
                    age = Console.ReadLine();
                    check = int.TryParse(age, out int result);
                }
                while (!check);
                config.AppSettings.Settings.Add("age", age);
                Console.WriteLine("Введите вашу профессию:");
                config.AppSettings.Settings.Add("prof", Console.ReadLine());
                config.Save();

            }
            if (ConfigurationManager.AppSettings["username"] != null) 
            {
                ;
                config.AppSettings.Settings["age"].Value = null;
                config.AppSettings.Settings["prof"].Value = null;

                Console.WriteLine("Изменить данные? (да/нет)");
                string change = Console.ReadLine();
                if (change == "да")
                {
                    Console.WriteLine("Введите имя пользователя:");
                    config.AppSettings.Settings["username"].Value = Console.ReadLine();
                    Console.WriteLine("Введите Ваш возраст:");
                    do
                    {
                        age = Console.ReadLine();
                        check = int.TryParse(age, out int result);
                    }
                    while (!check);
                    config.AppSettings.Settings["age"].Value = age;
                    Console.WriteLine("Введите вашу профессию:");
                    config.AppSettings.Settings["prof"].Value = Console.ReadLine(); ;
                    config.Save();
                }
            }

            
            var name = config.AppSettings.Settings["username"].Value;
            age = config.AppSettings.Settings["age"].Value;
            prof = config.AppSettings.Settings["prof"].Value;
            Console.WriteLine($"{name}, {age}, {prof}");








        }
    }
}
