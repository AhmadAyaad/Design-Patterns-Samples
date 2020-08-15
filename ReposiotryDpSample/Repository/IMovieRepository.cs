using ReposiotryDpSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReposiotryDpSample.Repository
{
    interface IMovieRepository
    {
        void CreateMovie(Movie movie);
        void DeleteMovie(Movie movie);
    }
}
