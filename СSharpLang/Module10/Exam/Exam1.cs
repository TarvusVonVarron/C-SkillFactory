using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Exam1
    {
        public interface ICalculator
        {
            double Add(double a, double b);
        }

        public class SimpleCalculator : ICalculator
        {
            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        public static void Run()
        {
            ICalculator calculator = new SimpleCalculator();

            try
            {
                // Запрос первого числа
                Console.WriteLine("Введите первое число:");
                double num1 = double.Parse(Console.ReadLine());

                // Запрос второго числа
                Console.WriteLine("Введите второе число:");
                double num2 = double.Parse(Console.ReadLine());

                // Выполнение операции сложения
                double result = calculator.Add(num1, num2);

                // Вывод результата
                Console.WriteLine($"Результат сложения: {num1} + {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное значение. Пожалуйста, введите числовое значение.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }
    }
}
