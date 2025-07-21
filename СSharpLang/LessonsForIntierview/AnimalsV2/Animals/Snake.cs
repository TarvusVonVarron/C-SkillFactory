using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    class Snake : IAnimal, IEater
    {
        public void Speak() => Console.WriteLine("Hisssss");
        public void Eat() => Console.WriteLine("Swallows a mouse whole");
    }
}
