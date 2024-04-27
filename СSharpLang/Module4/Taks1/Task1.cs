using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public static class Task1
    {
        public static void Run()
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
            int usersCount = 0;
            while (usersCount < 3)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                while (true)
                {
                    var hasPetString = Console.ReadLine();
                    if (hasPetString == "Да")
                    {
                        User.HasPet = true;
                        break;
                    }
                    else if (hasPetString == "Нет")
                    {
                        User.HasPet = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод, пожалуйста введите 'Да' или 'Нет'.");
                    }
                }

                Console.WriteLine("Введите возраст пользователя");
                while (!double.TryParse(Console.ReadLine(), out User.Age))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
                }

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
                usersCount++;
            }
        }
    }
}
