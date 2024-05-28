using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    static class IntExtensions
    {
        public static int GetNegative(this int number)
        {
            if (number > 0)
                return -number;
            else
                return number;
        }
        public static int GetPositive(this int number)
        {
            if (number < 0)
                return -number;
            else
                return number;
        }
    }

    internal static class Task6
    {
        class Obj
        {
            string Name;
            string Description;

            public static string Parent;
            public static int DaysInWeek;
            public static int Maxnumber;

            static Obj()
            {
                Parent = "System.Object";
                DaysInWeek = 7;
                Maxnumber = 2000;
            }
        }
        
        class Helper
        {
            public static void Swap(ref int a, ref int b)
            {
                int tenp = a;
                a = b;
                b = tenp;
            }
        }

        public static void Run() 
        {
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1,ref num2);

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3

            num1 = 7;
            num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
        }
    }
}
