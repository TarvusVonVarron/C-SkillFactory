using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Task2
    {
        public interface IWriter
        {
            void Write();
        }

        class Writer : IWriter
        {
            void IWriter.Write() { }
        }
        public interface IWorker
        {
            public void Build();
        }

        public class Worker : IWorker
        {
            public void Build() { }
        }
        public static void Run()
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();

            Console.ReadKey();

        }
    }
}
