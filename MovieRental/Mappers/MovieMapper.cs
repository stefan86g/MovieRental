using DBMovieRent;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Mappers
{
    public class MovieMapper
    {
        //Model To ViewModel
        public static MovieViewModel MapModelToViewModel(Movie movie)
        {
            MovieViewModel movieVM = new MovieViewModel();
            

            movieVM.Picture = movie.Picture;
            movieVM.Title = movie.Title;
            movieVM.ReleaseDate = Convert.ToDateTime(movie.ReleaseDate);
            movieVM.Genre = movie.Genre;
            movieVM.Price = movie.Price.ToString();
            movieVM.Availability = movie.Availability;

            return movieVM;
        }

        //ViewModel To Model
        public static DBMovieRent.Movie MapViewModelToModel(MovieViewModel movieVM)
        {
            DBMovieRent.Movie movie = new DBMovieRent.Movie();

            movie.Picture = movieVM.Picture;
            movie.Title = movieVM.Title;
            movie.ReleaseDate = movieVM.ReleaseDate;
            movie.Genre = movieVM.Genre;
            movie.Price = string.IsNullOrEmpty(movieVM.Price) ? 0 : Int32.Parse(movieVM.Price);
            movie.Availability = movieVM.Availability;
            return movie;
        }
    }
}