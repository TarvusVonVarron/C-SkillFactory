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
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void TestActions(string msg)
        {

            Console.WriteLine(msg);

        }

        public static bool TestPredicate(int a)
        {
            return a > 100;
        }

        public delegate int IntDelegate(int a, int b);

        delegate void ShowMessageDelegate(string _message);
        delegate int RandomNumberDelegate();

        public static void Run()
        {
            IntDelegate intDelegate;
            intDelegate = Subtraction;
            Console.WriteLine(intDelegate(5, 2));
            Console.WriteLine(intDelegate.Invoke(5, 2));

            intDelegate += Sum;

            Console.WriteLine(intDelegate.Invoke(5, 2));

            intDelegate -= Sum;
            Console.WriteLine(intDelegate.Invoke(5, 2));

            IntDelegate calcDelegateOne = Subtraction;
            IntDelegate calcDelegateTwo = Sum;
            IntDelegate calcDelegateThree = calcDelegateOne + calcDelegateTwo;
            calcDelegateThree.Invoke(100, 55);

            Func<int, int, int> sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 30);
            Console.WriteLine(result);

            Action<string> action = TestActions;
            action.Invoke("Test");

            Predicate<int> predicate = TestPredicate;
            predicate.Invoke(111);



            //anonimous methods
            ShowMessageDelegate showMessage = delegate (string a)
            {
                Console.WriteLine(a);
            };

            showMessage.Invoke("Test");

            RandomNumberDelegate randomNumber = delegate
            {
                return new Random().Next(0, 100);
            };

            var rand = randomNumber.Invoke();

            showMessage = c => Console.WriteLine(c);
            randomNumber = () => new Random().Next(0, 100);
        }
    }
}
