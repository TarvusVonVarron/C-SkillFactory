using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module8
{
    internal class Exam
    {
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public DateTime DateOfBirth { get; set; }
            public decimal AverageGrade { get; set; }
        }

        static List<Student> ReadStudentsFromBinaryFile(string filePath)
        {
            List<Student> students = new List<Student>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                while (fs.Position < fs.Length)
                {
                    string name = reader.ReadString();
                    string group = reader.ReadString();
                    DateTime dateOfBirth = DateTime.FromBinary(reader.ReadInt64());
                    decimal averageGrade = reader.ReadDecimal();

                    students.Add(new Student
                    {
                        Name = name,
                        Group = group,
                        DateOfBirth = dateOfBirth,
                        AverageGrade = averageGrade
                    });
                }
            }

            return students;
        }

        static void WriteStudentsToTextFiles(string outputDirectory, List<Student> students)
        {
            var groupedStudents = students.GroupBy(s => s.Group);

            foreach (var group in groupedStudents)
            {
                string groupFilePath = Path.Combine(outputDirectory, $"{group.Key}.txt");

                using (StreamWriter writer = new StreamWriter(groupFilePath))
                {
                    foreach (var student in group)
                    {
                        writer.WriteLine($"{student.Name}, {student.DateOfBirth:yyyy-MM-dd}, {student.AverageGrade:F2}");
                    }
                }
            }
        }

        static long GetDirectorySize(string directoryPath)
        {
            long totalSize = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);

            if (!dirInfo.Exists)
            {
                throw new DirectoryNotFoundException($"Directory not found: {directoryPath}");
            }

            // Считаем размер всех файлов в директории
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                totalSize += file.Length;
            }

            // Рекурсивно считаем размер всех поддиректорий
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                totalSize += GetDirectorySize(dir.FullName);
            }

            return totalSize;
        }

        static (int, long) ClearCatalog(string directoryPath)
        {
            int deletedFilesCount = 0;
            long freedSpace = 0;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
                if (dirInfo.Exists)
                {
                    // Удаляем файлы
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        if ((DateTime.Now - file.LastAccessTime).TotalMinutes > 30)
                        {
                            freedSpace += file.Length;
                            file.Delete();
                            deletedFilesCount++;
                        }
                    }

                    // Удаляем папки
                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        if ((DateTime.Now - dir.LastAccessTime).TotalMinutes > 30)
                        {
                            long dirSize = GetDirectorySize(dir.FullName);
                            freedSpace += dirSize;
                            dir.Delete(true);
                            deletedFilesCount++; // Считаем папку как один удаленный элемент
                        }
                    }
                }
                else
                {
                    throw new Exception("Такой папки не существует");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (deletedFilesCount, freedSpace);
        }
        public static void Run()
        {
            Console.WriteLine("Enter the path to the directory:");
            string directoryPath = Console.ReadLine();

            try
            {
                long initialSize = GetDirectorySize(directoryPath);
                Console.WriteLine($"The total size of the directory before cleaning is: {initialSize} bytes");

                (int deletedFilesCount, long freedSpace) = ClearCatalog(directoryPath);

                long finalSize = GetDirectorySize(directoryPath);
                Console.WriteLine($"The total size of the directory after cleaning is: {finalSize} bytes");
                Console.WriteLine($"Number of deleted files/directories: {deletedFilesCount}");
                Console.WriteLine($"Freed space: {freedSpace} bytes");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
