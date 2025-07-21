using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Exam1
    {
        public class MyCustomException : Exception
        {
            public MyCustomException(string message) : base(message)
            {
            }
        }

        public static void Run()
        {
            Exception[] exceptions = new Exception[]
            {
            new MyCustomException("Мое собственное исключение"),
            new ArgumentNullException("Аргумент не должен быть null"),
            new IndexOutOfRangeException("Индекс вне диапазона"),
            new DivideByZeroException("Деление на ноль"),
            new InvalidOperationException("Недопустимая операция")
            };

            foreach (var ex in exceptions)
            {
                try
                {
                    // Инициируем исключение
                    throw ex;
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine($"Поймано исключение: {ane.Message}");
                }
                catch (IndexOutOfRangeException iore)
                {
                    Console.WriteLine($"Поймано исключение: {iore.Message}");
                }
                catch (MyCustomException mce)
                {
                    Console.WriteLine($"Поймано исключение: {mce.Message}");
                }
                catch (DivideByZeroException dbze)
                {
                    Console.WriteLine($"Поймано исключение: {dbze.Message}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"Поймано исключение: {ioe.Message}");
                }
                finally
                {
                    // Этот блок всегда выполняется
                    Console.WriteLine("Блок finally выполняется.");
                }

            }
        }
    }
}
