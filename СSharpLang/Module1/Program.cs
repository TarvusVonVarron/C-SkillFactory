using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (1 или 2):");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
