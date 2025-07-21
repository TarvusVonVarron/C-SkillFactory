using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    class Cat : IAnimal, IEater, IPet
    {
        public void Speak() => Console.WriteLine("Meow-meow");
        public void Eat() => Console.WriteLine("Eats fish");
        public void PlayWithOwner() => Console.WriteLine("Plays with laser");
    }
}
