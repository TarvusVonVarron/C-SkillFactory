using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    internal class Snake : IAnimal, IEater
    {
        public void Speak()
        {
            Console.WriteLine("Parseltongue whispering");
        }

        public void Eat()
        {
            Console.WriteLine("Let's eat some rats");
        }
    }
}
