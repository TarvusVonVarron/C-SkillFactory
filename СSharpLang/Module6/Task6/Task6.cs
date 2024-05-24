using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    internal class Task6
    {

        public class TrafficLight
        {
            private void ChangeColor(string color)
            {

            }
            public string GetColor()
            {
                return string.Empty;  
            }
        }

        class User
        {
            private int age;
            private string login;
            private string mail;

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Возраст должен быть не меньше 18");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }

            public string Login
            {
                get { return login; }
                set
                {
                    if (value.Length<3)
                    {
                        Console.WriteLine("At least 3 characters");
                    }
                    else
                    {
                        login = value;
                    }
                }
            }

            public string Mail
            {
                get { return mail; }
                set
                {
                    if (!value.Contains('@'))
                    {
                        Console.WriteLine("The mail must contains @ character");
                    }
                    else
                    {
                        mail = value;
                    }
                }
            }
        }

        public void Run() 
        { 
        
        }
    }
}
