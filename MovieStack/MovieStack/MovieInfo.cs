using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStack
{
    public class MovieInfo
    {
        public static List<Movie> MovieList = null;

        public MovieInfo()
        {
            if(MovieList == null)
            {
                MovieList = new List<Movie>(); 
            }
        }

        public void AddMovie(Movie newmovie)
        {
            MovieList.Add(newmovie);
        }

        public List<Movie> ViewMoviesByGenre(string genre)
        {
            var moviebygenre = from m in MovieList
                               where m.Genre == genre
                               select m;

            return moviebygenre.ToList();
        }

        public List<Movie> ViewMoviesByRatings()
        {
            var movieByRatings = from m in MovieList
                                 orderby m.Ratings
                                 select m;
            return movieByRatings.ToList();
        }

    }
}
