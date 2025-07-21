using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsForIntierview.LINQ
{
    internal class UserHandler
    {
        public void StartLesson()
        {
            var data = new List<User>
            {
                new User("Alice", new[] { "C#", "SQL" }),
                new User("Bob", new[] { "Java", "Kotlin" }),
                new User("Charlie", new[] { "C#", "Python", "Go" }),
                new User("Diana", new string[] { }),
                new User("Eve", new[] { "C#", "SQL", "Python" })
            };

            var result = data
                .Where(u => u.Skills.Any())
                .SelectMany(u => u.Skills.Select(s => (User: u, Skill: s)))
                .GroupBy(us => us.Skill)
                .Select(g => new {
                    Skill = g.Key,
                    Count = g.Count(),
                    Users = g.Select(x => x.User.Name).Distinct()
                })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.Skill)
                .ToList();
        }
    }
}
