using ReposiotryDpSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReposiotryDpSample.Repository
{
    class MovieDbRepo : IMovieRepository
    {
        public void CreateMovie(Movie movie)
        {
            Movie newMovie = new Movie
            {
                MovieId = movie.MovieId,
                MovieName = movie.MovieName,
                PublishDate = movie.PublishDate,
                Rate = movie.Rate
            };

            Console.WriteLine($"Moive :{newMovie.MovieName} create in the db");

        }

        public void DeleteMovie(Movie movie)
        {
            Console.WriteLine($"Moive {movie.MovieName} has been deleted from the database");
        }

    }
}
