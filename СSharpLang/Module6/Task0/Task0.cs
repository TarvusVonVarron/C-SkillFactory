using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public static class Task0
    {
        public static string GetString(string firstObject, params object[] objects)
        {
            return "";
        }

        //Напишите выражение для параметра метода AddTen вместо ??? так, чтобы в консоли отображалось число 11.

    class Program0
    {
	static void Main0(string[] args)
        {
            var num = 1;

            AddTen(ref num);

            Console.WriteLine(num);

        }

        static void AddTen(ref int num)
        {
            num = num + 10;
        }
    }
    public static void Run()
        {

        }
    }
}
