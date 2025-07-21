using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Exam2
    {
        public class InvalidInputException : Exception
        {
            public InvalidInputException(string message) : base(message)
            {
            }
        }

        public static void Run()
        {
            // Список фамилий
            List<string> lastNames = new List<string> { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов" };

            // Создаем объект NameSorter
            NameSorter sorter = new NameSorter();

            try
            {
                Console.WriteLine("Введите 1 для сортировки по возрастанию (А-Я) или 2 для сортировки по убыванию (Я-А):");
                int sortOrder = int.Parse(Console.ReadLine());

                // Вызываем сортировку
                sorter.SortNames(sortOrder, lastNames);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Ожидалось число 1 или 2.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Работа программы завершена.");
            }
        }

        public class NameSorter
        {
            // Делегат для обработки события сортировки
            public delegate void SortHandler(List<string> names);

            // Событие, которое будет вызываться при сортировке
            public event SortHandler OnSort;

            // Метод для запуска сортировки
            public void SortNames(int sortOrder, List<string> names)
            {
                switch (sortOrder)
                {
                    case 1:
                        OnSort += SortAscending;
                        break;
                    case 2:
                        OnSort += SortDescending;
                        break;
                    default:
                        throw new InvalidInputException("Введено неверное значение. Введите 1 или 2.");
                }

                OnSort?.Invoke(names);
            }

            private void SortAscending(List<string> names)
            {
                names.Sort();
                Console.WriteLine("Список отсортирован по возрастанию (А-Я):");
                names.ForEach(Console.WriteLine);
            }

            private void SortDescending(List<string> names)
            {
                names.Sort();
                names.Reverse();
                Console.WriteLine("Список отсортирован по убыванию (Я-А):");
                names.ForEach(Console.WriteLine);
            }
        }
    }
}
