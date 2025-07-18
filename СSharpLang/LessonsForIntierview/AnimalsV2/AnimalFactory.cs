using LessonsForIntierview.AnimalsV2.Animals;
using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2
{
    abstract class AnimalFactory<T> where T : class
    {
        public abstract T Create(string type);
    }
    class AnimalBehaviorFactory : AnimalFactory<IAnimal>
    {
        public override IAnimal Create(string type)
        {
            switch (type)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                case "Snake":
                    return new Snake();
                default:
                    throw new NotImplementedException();
            }
        }
    }

    class PetBehaviorFactory : AnimalFactory<IPet>
    {
        public override IPet Create(string type)
        {
            switch (type)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                case "RobotDog":
                    return new RobotDog();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
