using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Task4
    {
        public interface IUpdater<in T>
        {
            void Update(T entity);
        }

        public class UserService : IUpdater<User>
        {
            public void Update(User entity)
            {
                throw new NotImplementedException();
            }
        }

        public class User
        {

        }

        public class Account : User
        {

        }
        public static void Run()
        {
            var user = new User();
            var account = new Account();

            IUpdater<Account> updater = new UserService();

            var userService = new UserService();
            userService.Update(user);
        }
    }
}
