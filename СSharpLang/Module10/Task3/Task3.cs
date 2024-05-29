using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Task3
{
    internal class Task3
    {
        public interface IWriter
        {
            void Write();
        }

        public interface IReader
        {
            void Read();
        }

        public interface IMailer
        {
            void SendEmail();
        }

        public class FileManager : IWriter, IReader, IMailer
        {
            public void Write() { }
            public void Read() { }
            public void SendEmail() { }
        }
        public interface ICreatable
        {
            void Create();
        }

        public interface IDeletable
        {
            void Delete();
        }

        public interface IUpdatable
        {
            void Update();
        }

        public class Entity : ICreatable, IDeletable, IUpdatable
        {
            public void Create()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }

        public interface IBook
        {
            void Read();
        }

        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }

        public class ElectronicBook : IBook, IDevice
        {
            void IBook.Read()
            {
                throw new NotImplementedException();
            }

            void IDevice.TurnOff()
            {
                throw new NotImplementedException();
            }

            void IDevice.TurnOn()
            {
                throw new NotImplementedException();
            }
        }
        public static void Run()
        {

        }
    }
}
