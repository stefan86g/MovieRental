using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMovieRent
{
   public class UserRepository : IDisposable
    {
        private DataMovieRentEntities context;
        private DbSet<User> users;

        public UserRepository()
        {
            context = new DataMovieRentEntities();
            users = context.Users;
        }


        // Register User
        public void RegisterUser(User user)
        {
            users.Add(user);

            context.SaveChanges();
        }

        //Authenticate user
        public User AuthenticateUser(string email, string password)
        {
            User user = users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            return user;
        }


        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }
        
    }
}
