using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module7
{
    internal static class Task3
    {
        public abstract class ComputerPart 
        {
            public abstract void Work();
        }

        public class Processor : ComputerPart
        {
            public override void Work() { }
        }
        public class MotherBoard : ComputerPart
        {
            public override void Work() { }
        }
        public class GraphicCard : ComputerPart
        {
            public override void Work() { }
        }
        abstract class Transport
        {
            public abstract void Move();
        }

        class Boat : Transport
        {
            public override void Move()
            {
                // ...
            }
        }

        class Car : Transport
        {
            public double Fuel;

            public int Mileage;

            public Car()
            {
                Fuel = 50;
                Mileage = 0;
            }
            public override void Move()
            {
                Mileage++;
                Fuel -= 0.5;
            }

            public void FillTheCar()
            {
                Fuel = 50;
            }
        }

        enum FuelType
        {
            Gas = 0,
            Electricity
        }

        class HybridCar : Car
        {
            public FuelType FuelType;

            public void ChangeFuelType(FuelType type)
            {
                FuelType = type;
            }
        }
        public static void Run()
        {

        }
    }
}
