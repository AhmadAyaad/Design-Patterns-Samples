using ReposiotryDpSample.Entities;
using ReposiotryDpSample.Repository;
using System;

namespace ReposiotryDpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovieRepository movieRepository = new MovieDbRepo();
            Movie movie = new Movie
            {
                MovieId = 1,
                MovieName = "Shrik",
                PublishDate = DateTime.Now,
                Rate = 1
            };
            movieRepository.CreateMovie(movie);
            movieRepository.DeleteMovie(movie);

            movieRepository = new MovieListRepo();
            movieRepository.CreateMovie(movie);
            movieRepository.DeleteMovie(movie);

        }
    }
}
