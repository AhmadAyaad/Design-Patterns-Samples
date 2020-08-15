using ReposiotryDpSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposiotryDpSample.Repository
{
    class MovieListRepo : IMovieRepository
    {

        static List<Movie> movies;
        public MovieListRepo()
        {
            movies = new List<Movie>();
        }

        public void CreateMovie(Movie movie)
        {
            movies.Add(movie);
            Console.WriteLine($"movie {movie.MovieName} has been added to the list");
        }

        public void DeleteMovie(Movie movie)
        {
            movies.Remove(movie);
            Console.WriteLine($"movie {movie.MovieName} has been removed to the list");

        }
    }
}
