using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    public class Person
    {
        public string Name { get; set; }
        public List<Car> Cars { get; set; }

        public Person(string name)
        {
            Name = name;
            Cars = new List<Car>();
        }
    }

    public class Car
    {
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }
    }
    public class University
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }

        public University(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }
    }

    public class Department
    {
        public string Name { get; set; }

        public Department(string name)
        {
            Name = name;
        }
    }

    public class House
    {
        private List<Room> rooms; // Композиция с классом Room

        public House()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(string name, int area)
        {
            rooms.Add(new Room(name, area));
        }

        public void ShowRooms()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room: {room.Name}, Area: {room.Area} sq. ft.");
            }
        }
    }

    public class Room
    {
        public string Name { get; set; }
        public int Area { get; set; }

        public Room(string name, int area)
        {
            Name = name;
            Area = area;
        }
    }
    internal class Task5
    {
        public void Run()
        {
            Person person1 = new Person("John");
            Car car1 = new Car("Toyota");

            person1.Cars.Add(car1);

            Console.WriteLine($"{person1.Name} has a {car1.Model}");

            University university = new University("Oxford");
            Department department1 = new Department("Computer Science");

            university.Departments.Add(department1);

            Console.WriteLine($"{department1.Name} is part of {university.Name}");

            House house = new House();
            house.AddRoom("Living Room", 250);
            house.AddRoom("Bedroom", 150);
            house.AddRoom("Kitchen", 200);

            house.ShowRooms();
        }
    }
}
