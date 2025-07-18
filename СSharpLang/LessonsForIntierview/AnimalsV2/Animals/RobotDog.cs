using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2.Animals
{
    internal class RobotDog : IPet
    {
        public void PlayWithOwner()
        {
            Console.WriteLine("Play with stones");
        }
    }
}
