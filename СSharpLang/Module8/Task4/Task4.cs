using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Task4
    {
        const string BinFile = @"C:\\Users\\HP\\source\\repos\\C-SkillFactory\\СSharpLang\\Module8\\Task4\\BinaryFile.bin";

        static void WriteValues()
        {
            // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
            using (BinaryWriter writer = new BinaryWriter(File.Open(BinFile, FileMode.Create)))
            {
                // записываем данные в разном формате
                writer.Write($"Файл изменен {DateTime.Now.ToString("dd.MM HH:mm")} на компьютере {Environment.OSVersion}");
            }
        }

        static void ReadValues()
        {
            string DataInFile;

            if (File.Exists(BinFile))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(BinFile, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.
                    DataInFile = reader.ReadString();
                }

                Console.WriteLine("Из файла считано:");

                Console.WriteLine(DataInFile);
            }
        }

        [Serializable]
        public class Contact
        {
            public string Name { get; set; }
            public long PhoneNumber { get; set; }
            public string Email { get; set; }

            public Contact(string name, long phoneNumber, string email)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }
        public static void Run()
        {
            WriteValues();
            ReadValues();

            // объект для сериализации
            var contact = new Contact("Denis", 2222222, "test@test.ru");
            Console.WriteLine("Объект создан");

            // сериализация
            //BinaryFormatter formatter = new BinaryFormatter();
            //using (var fs = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, contact);
            //}
        }
    }
}
