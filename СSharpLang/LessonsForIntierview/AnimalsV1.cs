using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview
{
    public class AnimalsV1
    {
        interface IPet
        {
            void PlayWithOwner();
        }

        abstract class Animal
        {
            public abstract void Speak();
            public virtual void Eat()
            {
                Console.WriteLine("Animal eats food");
            }
        }

        class Dog : Animal, IPet
        {
            public override void Speak()
            {
                Console.WriteLine("Woof-woof");
            }
            public override void Eat()
            {
                Console.WriteLine("Let's eat some cows");
            }
            public void PlayWithOwner()
            {
                Console.WriteLine("Play with bones");
            }
        }

        class Cat : Animal, IPet
        {
            public override void Speak()
            {
                Console.WriteLine("Meow-meow");
            }
            public override void Eat()
            {
                Console.WriteLine("Let's eat some fish");
            }
            public void PlayWithOwner()
            {
                Console.WriteLine("Play with laser");
            }
        }

        class Snake : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Parseltongue whispering");
            }
        }

        class RobotDog : IPet
        {
            public void PlayWithOwner()
            {
                Console.WriteLine("Play with stones");
            }
        }
        sealed class Bird : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Beautiful song");
            }
        }

        public void StartLesson()
        {
            var animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Snake(),
                new Bird()
            };
            var pets = new List<IPet>
            {
                new Dog(),
                new Cat(),
                new RobotDog()
            };

            foreach (Animal animal in animals) { animal.Speak(); animal.Eat(); }

            Console.WriteLine();

            foreach (IPet pet in pets) { pet.PlayWithOwner(); }
        }
    }
}
