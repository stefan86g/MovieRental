using BOLMovieRent.Movies;
using MovieRental.Mappers;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MovieRental.Controllers
{
    public class UserController : Controller
    {
        private UserService userService;

        public UserController()
        {
            userService = new UserService();
        }

        //Add new User
        [HttpPost]
        public ActionResult RegisterUser(UserViewModel model)
        {
            DBMovieRent.User user = UserMapper.UserMapViewModelToModel(model);

            this.userService.RegisterNewUser(user);

            return RedirectToAction("RegisterUser");
        }
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View("RegisterUser");
        }

        
    }
}