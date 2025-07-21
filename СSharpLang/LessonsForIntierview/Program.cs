using LessonsForIntierview;
using LessonsForIntierview.AnimalsV2;
using LessonsForIntierview.LINQ;
using System;
using System.Collections.Generic;

namespace LessonsForInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalsV1 v1 = new AnimalsV1();
            AnimalsV2 v2 = new AnimalsV2();
            Console.WriteLine("Первая версия\n");
            v1.StartLesson();
            Console.ReadKey();
            Console.WriteLine("\nВторая версия\n");
            v2.StartLesson();
            Console.ReadKey();

            UserHandler uh = new UserHandler();

            uh.StartLesson();
        }
    }
}
