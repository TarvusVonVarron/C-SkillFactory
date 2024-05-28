using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class Task7
    {
        abstract class Car<TEngine> where TEngine : Engine
        {
            public TEngine TypeEngine;
            public virtual void ChangePart<TPart>(TPart newPart) where TPart : Part { }
        }

        class ElectricCar : Car<ElectricEngine> 
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }
        class GasCar : Car<GasEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }
        abstract class Engine { }
        class ElectricEngine : Engine { }

        class GasEngine : Engine { }
        abstract class  Part { }

        class Battery : Part  { }

        class Differential : Part { }

        class Wheel : Part { }
        class Record<T1, T2>
        {
            public T1 Id;
            public T2 Value;
            public DateTime Date;
        }
        public static void Run()
        {

        }
    }
}
