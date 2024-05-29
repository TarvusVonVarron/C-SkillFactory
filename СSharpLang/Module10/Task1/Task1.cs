using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Module10.Task1;

namespace Module10
{
    internal class Task1
    {
        public interface IManager
        {
            public void Create();
            public void Update();
            public void Read();
            public void Delete();
        }
        public class Manager : IManager
        {
            public void Create()
            {

            }

            public void Read()
            {

            }

            public void Update()
            {

            }

            public void Delete()
            {

            }
        }
        public static void Run()
        {

        }
    }
}
