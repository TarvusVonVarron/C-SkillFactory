using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal static class Task2
    {
        public class BaseClass
        {
            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }

            public virtual int Counter
            {
                get;
                set;
            }
            public virtual void Method()
            {
            }
        }
        public class DerivedClass : BaseClass
        {

            private int counter;
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Метод класса DerivedClass");
            }
            public override int Counter
            {
                set
                {
                    if(value < 0)
                    {
                        Console.WriteLine("нельзя вводить числа меньше 0");
                    }
                    else
                    {
                        counter = value;
                    }
                }
            }
            public new void Method()
            {
            }
        }

        class A
        {
            public virtual void Display()
            {
                Console.WriteLine("Вызван метод класса A");
            }
        }
        class B : A
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса B");
            }
        }
        class C : A
        {
            public override void Display()
            {
                Console.WriteLine("Вызван метод класса C");
            }
        }
        class D : B
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса D");
            }
        }
        class E : C
        {
            public new void Display()
            {
                Console.WriteLine("Вызван метод класса E");
            }
        }

        class Obj
        {
            public int Value;

            public static Obj operator +(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator -(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
        }

        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            // Индексатор по массиву
            public int this[int index]
            {
                get
                {
                    return array[index];
                }

                private set
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < array.Length)
                    {
                        array[index] = value;
                    }
                }
            }
        }

        public static void Run()
        {
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();

            DerivedClass obj = new DerivedClass();
            obj.Display();
        }
    }
}
