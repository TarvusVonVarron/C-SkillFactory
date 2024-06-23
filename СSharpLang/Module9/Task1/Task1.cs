using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Task1
    {
        public class MyException : Exception
        {
            public override string Message { get; }
            public new string HelpLink = "blabla";

        }
        public static void Run()
        {
            Exception ex = new Exception("Собственное исключения");
            ex.Data.Add("Дата создания исключения: ", DateTime.Now);
            ex.HelpLink = "www.google.ru";
        }
    }
}
