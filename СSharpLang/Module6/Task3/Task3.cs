using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class Task3
    {
        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }
        static Department GetCurrentDepartment()
        {
            Department department = new Department();
            if(department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург") 
            {
                Console.WriteLine("У банка "+ department?.Company?.Name ?? "Неизвестная компания" + " есть отделение в Санкт - Петербурге");
            }
            return department;
        }

        class Bus
        {
            public int? Load;

            public void PrintStatus()
            {
                if (Load.HasValue && Load>0)
                {
                    Console.WriteLine($"В автобусе {Load} пассажиров");
                }
                else
                    Console.WriteLine("Автобус пуст");
            }
        }

        public static void Run() 
        {
            var department = GetCurrentDepartment();
        }
    }
}
