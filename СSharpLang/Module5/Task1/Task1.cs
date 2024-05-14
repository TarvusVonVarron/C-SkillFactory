using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    public static class Task1
    {
        public static void Run()
        {
            var user = CreateTuple();
            ShowTuple(user);
        }

        private static (string Name, string LastName, int Age, bool HasPet, string[] Pets, string[] FavColors) CreateTuple()
        {
            (string Name, string LastName, int Age, bool HasPet, string[] Pets, string[] FavColors) User = ("", "", 0, false, null, null);

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите возраст пользователя");
            User.Age = GetValidIntInput();

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            while (true)
            {
                var hasPetString = Console.ReadLine();
                if (hasPetString.ToLower() == "да")
                {
                    User.HasPet = true;
                    Console.WriteLine("Введите количество питомцев");
                    int petsCount = GetValidIntInput();
                    User.Pets = AddPets(petsCount);
                    break;
                }
                else if (hasPetString.ToLower() == "нет")
                {
                    User.HasPet = false;
                    User.Pets = new string[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод, пожалуйста введите 'Да' или 'Нет'.");
                }
            }

            Console.WriteLine("Введите количество любимых цветов");
            int colorsCount = GetValidIntInput();
            User.FavColors = AddColors(colorsCount);

            return User;
        }

        private static string[] AddColors(int colorsCount)
        {
            string[] colors = new string[colorsCount];
            for (int i = 0; i < colorsCount; i++)
            {
                Console.WriteLine("Введите название цвета номер " + (i + 1));
                colors[i] = Console.ReadLine();
            }
            return colors;
        } 
        private static string[] AddPets(int petsCount) 
        {
            string[] pets = new string[petsCount];
            for (int i = 0; i < petsCount; i++)
            {
                Console.WriteLine("Введите имя питомца номер " + (i + 1));
                pets[i] = Console.ReadLine();
            }
            return pets;
        }

        private static int GetValidIntInput()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число больше 0:");
            }
            return result;
        }

        private static void ShowTuple((string Name, string LastName, int Age, bool HasPet, string[] Pets, string[] FavColors) user)
        {
            Console.WriteLine($"Имя: {user.Name}");
            Console.WriteLine($"Фамилия: {user.LastName}");
            Console.WriteLine($"Возраст: {user.Age}");
            Console.WriteLine($"Наличие питомца: {(user.HasPet ? "Да" : "Нет")}");

            if (user.HasPet)
            {
                Console.WriteLine("Питомцы:");
                foreach (var pet in user.Pets)
                {
                    Console.WriteLine($"- {pet}");
                }
            }

            Console.WriteLine("Любимые цвета:");
            foreach (var color in user.FavColors)
            {
                Console.WriteLine($"- {color}");
            }
        }
    }
}
