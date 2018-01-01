using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMovieRent
{
   public class MovieRepository : IDisposable
    {
        private DataMovieRentEntities context;
        private DbSet<Movie> movies;


        public MovieRepository()
        {
            context = new DataMovieRentEntities();
            movies = context.Movies1;
        }

        //Get  By Id
        public Movie GetMovieById(int id)
        {
            return movies.Find(id);
        }

        //Get  By Title
        public Movie GetMovieByTitle(string title)
        {
            return movies.FirstOrDefault(m => m.Title == title);
        }


        //Get All Movies
        public IEnumerable<Movie> GetAllMoviesRepository()
        {
            return movies.ToList();
        }

        //Add movie to database
        public void Insert(Movie movie)
        {
            movies.Add(movie);

            context.SaveChanges();
        }

        //Edit existed Movie
        public void Update(string title, Movie movieForUpdate)
        {
            Movie movie = context.Movies1.FirstOrDefault(c => c.Title == title);
            if (movie != null)
            {
                movie.Title = movieForUpdate.Title;
                movie.ReleaseDate = movieForUpdate.ReleaseDate;
                movie.Genre = movieForUpdate.Genre;
                movie.Price = movieForUpdate.Price;
                context.SaveChanges();
            }
        }

        // Delete movie from database
        public void Delete(string title)
        {
            Movie movie = context.Movies1.FirstOrDefault(c => c.Title == title);
            context.Movies1.Remove(movie);
            context.SaveChanges();
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
