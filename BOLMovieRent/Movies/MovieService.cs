using DBMovieRent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLMovieRent.Movies
{
    public class MovieService
    {
        
        //get all Movies
        public IEnumerable<DBMovieRent.Movie> GetAllMovies()
        {
            IEnumerable<DBMovieRent.Movie> movies;
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                movies = moviesRepository.GetAllMoviesRepository();
            }
            return movies;
        }

        //get available Movies
        public IEnumerable<DBMovieRent.Movie> GetAvailableMovies()
        {
            IEnumerable<DBMovieRent.Movie> movies;
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                movies = moviesRepository.GetAllAvailableMovies();
            }
            return movies;
        }

        //get NOT available Movies
        public IEnumerable<DBMovieRent.Movie> GetNotAvailableMovies()
        {
            IEnumerable<DBMovieRent.Movie> movies;
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                movies = moviesRepository.GetAllNotAvailableMovies();
            }
            return movies;
        }



        //get  by id
        public Movie GetById(int id)
        {
            DBMovieRent.Movie movie = null;
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                movie = moviesRepository.GetMovieById(id);
            }
            return movie;
        }


        //get movie by title
        public Movie GetByTitle(string title)
        {
            DBMovieRent.Movie movie = null;
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                movie = moviesRepository.GetMovieByTitle(title);
            }
            return movie;
        }

        //add new movie
        public void Insert(DBMovieRent.Movie movieVM)
        {
         
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                moviesRepository.Insert(movieVM);
            }
        }


        //Edit movie
        public void Edit(DBMovieRent.Movie movieVM)
        {
            using (MovieRepository moviesRepository = new MovieRepository())
            {
                var movieTitle = movieVM.Title;
                moviesRepository.Update(movieTitle, movieVM);
            }
        }

        //delete movie
        public void Delete(string title)
        {

            using (MovieRepository moviesRepository = new MovieRepository())
            {
                moviesRepository.Delete(title);
            }

        }

       
    }
}
