using LessonsForIntierview.AnimalsV2.Animals;
using LessonsForIntierview.AnimalsV2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.AnimalsV2
{
    internal class AnimalsV2
    {

        public void StartLesson()
        {
            var animalFactory = new AnimalBehaviorFactory();
            var petFactory = new PetBehaviorFactory();

            var animals = new List<string> { "Cat", "Dog", "Snake" };
            var pets = new List<string> { "Cat", "Dog", "RobotDog" };

            foreach (var animal in animals)
            {
                var createdAnimal = animalFactory.Create(animal);
                if (createdAnimal is IAnimal a) a.Speak();
                if (createdAnimal is IEater e) e.Eat();
                if (createdAnimal is IPet p) p.PlayWithOwner();
                Console.WriteLine();
            }

            foreach (var pet in pets)
            {
                var createdPet = petFactory.Create(pet);
                if (createdPet is IAnimal a) a.Speak();
                if (createdPet is IEater e) e.Eat();
                if (createdPet is IPet p) p.PlayWithOwner();
                Console.WriteLine();
            }
        }
    }
}
