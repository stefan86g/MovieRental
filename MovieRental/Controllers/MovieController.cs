using BOLMovieRent.Movies;
using DBMovieRent;
using MovieRental.Mappers;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MovieRental.Controllers
{
    [Authorize]
    public class MovieController : Controller
    {

        private MovieService movieService;

        public MovieController()
        {
            movieService = new MovieService();
        }

        // Get all movies list
        [HttpGet]
        public ActionResult GetMovies()
        {
            IEnumerable<Movie> movies = movieService.GetAllMovies();
            List<MovieViewModel> moviesVMs = new List<MovieViewModel>();
            foreach (Movie movie in movies)
            {
                MovieViewModel movieVM   = MovieMapper.MapModelToViewModel(movie);
                moviesVMs.Add(movieVM);
            }
               
            return View(moviesVMs);
        }

        //Add new Movie
        [HttpPost]
        public ActionResult AddMovie(MovieViewModel model)
        {
            DBMovieRent.Movie movie = MovieMapper.MapViewModelToModel(model);

            this.movieService.Insert(movie);

            return RedirectToAction("GetMovies");
        }
        [HttpGet]
        public ActionResult AddMovie()
        {
            return View("AddMovie");
        }


        /// <summary>
        /// This action return view of movie model for editing
        /// </summary>
        /// <param name="title">Title of the movie</param>
        /// <returns>View of the movie model</returns>
        [HttpGet]
        public ActionResult EditMovie(string title)
        {
            DBMovieRent.Movie movie = this.movieService.GetByTitle(title);
            MovieViewModel movieVM = MovieMapper.MapModelToViewModel(movie);
            return View(movieVM);
        }

        /// <summary>
        /// This action update movie and redirect to list of movies action
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EditMovie(MovieViewModel vm)
        {

            DBMovieRent.Movie movie = MovieMapper.MapViewModelToModel(vm);
            this.movieService.Edit(movie);
            return RedirectToAction("GetMovies");
        }

        //Delete Movie
        [HttpGet]
        public ActionResult DeleteMovie(string title)
        {
           
            DBMovieRent.Movie movie = this.movieService.GetByTitle(title);
            this.movieService.Delete(movie.Title);
            
            return RedirectToAction("GetMovies");
        }

        
    }
}