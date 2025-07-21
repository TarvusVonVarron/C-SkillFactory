namespace Module10;

internal class Exam2
{
    public static void Run()
    {
        ILogger logger = new ConsoleLogger();
        ICalculator calculator = new SimpleCalculator(logger);

        try
        {
            // Запрос первого числа
            Console.WriteLine("Введите первое число:");
            var num1 = double.Parse(Console.ReadLine());

            // Запрос второго числа
            Console.WriteLine("Введите второе число:");
            var num2 = double.Parse(Console.ReadLine());

            // Выполнение операции сложения
            var result = calculator.Add(num1, num2);

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
            var result = a + b;
            _logger.Log($"Выполнено сложение: {a} + {b} = {result}");
            return result;
        }
    }
}