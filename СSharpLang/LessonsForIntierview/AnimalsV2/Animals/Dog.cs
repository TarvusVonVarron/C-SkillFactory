using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    class Dog : IAnimal, IEater, IPet
    {
        public void Speak() => Console.WriteLine("Woof-woof");
        public void Eat() => Console.WriteLine("Eats beef");
        public void PlayWithOwner() => Console.WriteLine("Plays fetch");
    }
}
