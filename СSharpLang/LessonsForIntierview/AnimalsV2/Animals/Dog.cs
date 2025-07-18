using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    internal class Dog : IAnimal, IPet, IEater 
    {
        public void Speak()
        {
            Console.WriteLine("Woof-woof");
        }
        public void Eat()
        {
            Console.WriteLine("Let's eat some cows");
        }
        public void PlayWithOwner()
        {
            Console.WriteLine("Play with bones");
        }
    }
}
