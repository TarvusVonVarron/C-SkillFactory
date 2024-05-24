using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public static class Task5
    {
        public class Square
        {
            int a;
            public int Area()
            { 
                return a*a; 
            }

            public int Perimeter()
            {
                return a*4;
            }
        }

        public class Triangle
        {
            int a;
            int b;
            int c;
            public double Area()
            {
                double p = (a+b+c)/2;
                return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            }
            public int Perimeter()
            {
                return a+b+c;
            }
        }

        public class Round
        {
            int r;

            public double Area()
            {
                return Math.PI * r * r;
            }
            public double Perimeter()
            {
                return Math.PI * r * 2;
            }
        }
        public static void Run()
        {

        }
    }
}
