using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Task1
    {
        public class Folder
        {
            public List<string> Files { get; set; } = new List<string>();
        }
        class Drive
        {
            string Name { get; }
            long TotalSpace { get; }
            long FreeSpace { get; }

            public Drive(string Name, int Space, double FreeSpace)
            {
                this.Name = Name;
                this.Space = Space;
                this.FreeSpace = FreeSpace;
            }
            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
            public void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
            }
        }
        public static void Run()
        {

        }
    }
}
