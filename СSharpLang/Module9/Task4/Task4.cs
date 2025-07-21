using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Task4
    {
        public class Car { }
        public class Lexus : Car 
        {
            string modelName; 
            public Lexus(string modelName)
            {
            this.modelName = modelName; 
            }
        
        }

        public delegate Car CarModelDelegate(string name);

        public static Lexus Model(string name)
        {
            return new Lexus(name);
        }

        public class Parent {public string Name; }
        public class Child : Parent { }

        public delegate void FamilyDelegate(Child child);

        public static void GetName(Parent parent)
        {
            Console.WriteLine(parent.Name);
        }
        public static void Run()
        {
            //ковариация
            CarModelDelegate carModelDelegate;
            carModelDelegate = Model;
            carModelDelegate("LX");

            //Контравариантность 
            FamilyDelegate familyDelegate;
            familyDelegate = GetName;
            Child child = new Child();
            familyDelegate(child);
        }

    }
}
