using Npg_Test;
using System;
using System.Linq;

namespace DefaultNs
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var appContext = new ApplicationContext())
            {
                var usr1 = new User { Name = "User 1", Age = 1 };
                var usr2 = new User { Name = "User 2", Age = 1 };

                appContext.Users.AddRange(usr1, usr2);
                appContext.SaveChanges();
            }

            using (var appContext = new ApplicationContext())
            {
                var users = appContext.Users.ToList();

                Console.WriteLine("Users list: ");

                foreach (var user in users)
                    Console.WriteLine($"{user.Id}\t{user.Name}\t{user.Age}");
            }
        }
    }
}