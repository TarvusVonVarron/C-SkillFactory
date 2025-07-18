using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    internal class Cat : IAnimal, IPet, IEater
    {
        public void Speak()
        {
            Console.WriteLine("Meow-meow");
        }
        public void Eat()
        {
            Console.WriteLine("Let's eat some fish");
        }
        public void PlayWithOwner()
        {
            Console.WriteLine("Play with laser");
        }
    }
}
