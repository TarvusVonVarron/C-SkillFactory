using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Exam2
    {
        public interface ILogger
        {
            void Log(string message);
            void LogError(string message);
        }
        public class ConsoleLogger : ILogger
        {
            public void Log(string message)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(message);
                Console.ResetColor();
            }

            public void LogError(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
        public interface ICalculator
        {
            double Add(double a, double b);
        }

        public class SimpleCalculator : ICalculator
        {
            private readonly ILogger _logger;

            // Конструктор принимает логгер как зависимость
            public SimpleCalculator(ILogger logger)
            {
                _logger = logger;
            }

            public double Add(double a, double b)
            {
                double result = a + b;
                _logger.Log($"Выполнено сложение: {a} + {b} = {result}");
                return result;
            }
        }

        public static void Run()
        {
            ILogger logger = new ConsoleLogger();
            ICalculator calculator = new SimpleCalculator(logger);

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
                logger.LogError("Ошибка: введено некорректное значение. Пожалуйста, введите числовое значение.");
            }
            catch (Exception ex)
            {
                logger.LogError($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
            }
        }

        
    }
}
