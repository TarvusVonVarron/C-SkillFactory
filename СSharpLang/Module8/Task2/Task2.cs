using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module8
{
    internal class Task2
    {
        static void GetCatalogsAndFilesCount()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"E://");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                    DirectoryInfo newDirectory = new DirectoryInfo(@"E:/newDirectory");
                    if (!newDirectory.Exists)
                        newDirectory.Create();
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                    newDirectory.Delete(true); // Удаление со всем содержимым
                    if (newDirectory.Exists)
                        throw new Exception("Папка не удалилась");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static void AddToDesctopeAndDelete()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"E:/Users/MSI/Desktop/testFolder");
                string trashPath = "E:/Users/MSI/.Trash/testFolder";

                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void Run()
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем: {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }
            }
            Console.WriteLine();
            GetCatalogsAndFilesCount();
        }
    }
}
