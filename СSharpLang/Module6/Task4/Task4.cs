using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public static class Task4
    {
        public static void Run()
        {
            int i = 123;
            // Упаковка значения i в объект o
            object o = i;
            // Распаковка o
            int j = (int)o;
            string k = (string)o; //ошибка распаковки
        }
    }
}
