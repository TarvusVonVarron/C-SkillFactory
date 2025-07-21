using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.LINQ
{
    public class User
    {
        public string Name { get; }
        public List<string> Skills { get; }

        public User(string name, IEnumerable<string> skills)
        {
            Name = name;
            Skills = skills.ToList();
        }
    }

}
