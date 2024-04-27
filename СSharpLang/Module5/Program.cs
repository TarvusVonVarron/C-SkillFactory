using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания (1):");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Task1.Run();
                    break;
                default:
                    Console.WriteLine("Неправильный ввод.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
