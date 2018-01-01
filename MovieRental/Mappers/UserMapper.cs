using DBMovieRent;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Mappers
{
    public class UserMapper
    {

        //User model To ViewModel
        public static UserViewModel UserMapModelToViewModel(User user)
        {
            UserViewModel userVM = new UserViewModel();
            
            userVM.Email = user.Email;
            userVM.Password = user.Password;
            userVM.Role = user.Role;
            return userVM;
        }

        //ViewModel To User Model
        public static DBMovieRent.User UserMapViewModelToModel(UserViewModel userVM)
        {
            DBMovieRent.User user = new DBMovieRent.User();

            user.Email = userVM.Email;
            user.Password = userVM.Password;
            user.Role = "user";
            return user;
        }

    }
}