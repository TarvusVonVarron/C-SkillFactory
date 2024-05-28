using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "4":
                    Task4.Run();
                    break;
                case "5":
                    Task5.Run();
                    break;
                case "6":
                    Task6.Run();
                    break;
                case "7":
                    Task7.Run();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
