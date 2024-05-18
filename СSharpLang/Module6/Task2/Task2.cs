using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class Task2
    {
        class Human
        {
            // Поля класса
            public string name;
            public int age;

            public Human()
            {
                name = "Неизвестно";
                age = 20;
            }

            // Метод класса
            public void Greetings()
            {
                Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
            }
        }

        class Pen
        {
            public string color;
            public int cost;

            public Pen()
            { 
                color = "black";
                cost = 100;
            }

            public Pen(string penColor, int penCost)
            {
                color=penColor;
                cost = penCost;
            }
        }

        class Rectangle
        {
            public int a;
            public int b;

            public Rectangle()
            {
                a = 6;
                b = 4;
            }
            public Rectangle(int a)
            {
                this.a = a;
                this.b = a;
            }

            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public int Square()
            {
                return a * b;
            }
        }

        public static void Run()
        {
            Human human = new Human();
            human.Greetings();
            human = new Human { age = 10 , name = "Test"};
            human.Greetings();
        }
    }
}
