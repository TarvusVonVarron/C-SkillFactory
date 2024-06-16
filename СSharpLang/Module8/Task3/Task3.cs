using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;


namespace Module8
{
    internal class Task3
    {
        public static void ShowCodeOfThisFile()
        {
            string filePath = @"C:\Users\HP\source\repos\C-SkillFactory\СSharpLang\Module8\Task3\Task3.cs";

            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }

        public static void ShowAndAddString()
        {
            var fileInfo = new FileInfo("C:\\Users\\HP\\source\\repos\\C-SkillFactory\\СSharpLang\\Module8\\Task3\\Task3.cs");

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);

            }
        }
        public static void Run()
        {
            //ShowCodeOfThisFile();
            ShowAndAddString();
        }
    }
}
// Время запуска: 16.06.2024 18:53:48
// Время запуска: 16.06.2024 18:54:09
