using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Exam
    {
        static void ClearCatalog()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\HP\source\repos\C-SkillFactory\СSharpLang\Module8\Exam\TestFiles\");
                if (dirInfo.Exists)
                {
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        if((DateTime.Now - file.LastWriteTime).Minutes>30)
                        {
                            file.Delete();
                        }
                    }
                }
                else { throw new Exception("Такой папки не существует"); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Run()
        {
            ClearCatalog();
        }
    }
}
