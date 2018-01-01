using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMovieRent;

namespace BOLMovieRent.Movies
{
    public class UserService
    {

        //register user
        public void RegisterNewUser(DBMovieRent.User userVM)
        {
            
            using (UserRepository userRepository = new UserRepository())
            {
                userRepository.RegisterUser(userVM);
            }
        }

        //Authentication user
        public User Authentication(DBMovieRent.User AuthUser)
        {

           string email = AuthUser.Email;
           string password = AuthUser.Password;

            using (UserRepository userRepository = new UserRepository())
            {
                User auntificatedUser =  userRepository.AuthenticateUser(email, password);
                return auntificatedUser;
            }
        }
      
    }
}
