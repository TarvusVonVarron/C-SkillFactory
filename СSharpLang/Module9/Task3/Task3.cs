using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Task3
    {
        static void Subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        private static int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }

        static void Display(string message)
        {
            Console.WriteLine(message);
        }

        private static bool IsApple(string modelName)
        {
            if (modelName == "IPhone X") return true;
            else return false;
        }

        public delegate void SubDelegate(int a, int b);
        delegate void ShowMessageDelegate(string _message);
        delegate int RandomNumberDelegate();

        public static void Run()
        {
            SubDelegate subDelegate = Subtraction;
            subDelegate += Sum;
            subDelegate.Invoke(5, 10);

            subDelegate -= Sum;
            subDelegate.Invoke(5, 10);

            Func<int, int, int> Addition = AddNumbers;
            int result = Addition(10, 20);
            Console.WriteLine(result);

            Action<string> action = new Action<string>(Display);
            action("Привет разработчик!");
            Console.Read();

            Predicate<string> CheckIfApple = IsApple;
            bool result2 = CheckIfApple("IPhone X"); 
            if (result2) Console.WriteLine("Это IPhone X");


            ShowMessageDelegate showMessageDelegate = delegate (string _message)
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();

            ShowMessageDelegate showMessageDelegate2 = (x) => Console.WriteLine(x);


            RandomNumberDelegate randomNumberDelegate = delegate()
            {
                return new Random().Next(0, 100);
            };
            result = randomNumberDelegate.Invoke();

            RandomNumberDelegate randomNumberDelegate2 = () => new Random().Next(0, 100);
        }


    }
}
