using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStock
{
    public class MovieUtility
    {
        List<Movie> MovieList = new List<Movie>()
        {
            new Movie(){Title = "PK", Artist = "Anushka Sharma", Genre = "Comedy", Ratings = 4},
            new Movie(){Title = "3 Idiots", Artist = "Kareena Kapoor", Genre = "Comedy", Ratings = 5},
new Movie(){Title = "Dangal", Artist = "Fatima Sana Shaikh", Genre = "Drama", Ratings = 5},
new Movie(){Title = "Bahubali", Artist = "Prabhas", Genre = "Action", Ratings = 5},
new Movie(){Title = "Kabir Singh", Artist = "Kiara Advani", Genre = "Romance", Ratings = 3},
new Movie(){Title = "Chennai Express", Artist = "Deepika Padukone", Genre = "Comedy", Ratings = 4},
new Movie(){Title = "Padmaavat", Artist = "Deepika Padukone", Genre = "Drama", Ratings = 4},
new Movie(){Title = "War", Artist = "Hrithik Roshan", Genre = "Action", Ratings = 4},
new Movie(){Title = "Jab We Met", Artist = "Kareena Kapoor", Genre = "Romance", Ratings = 5},
new Movie(){Title = "Drishyam", Artist = "Ajay Devgn", Genre = "Thriller", Ratings = 5},
new Movie(){Title = "RRR", Artist = "Ram Charan", Genre = "Action", Ratings = 5},
new Movie(){Title = "Pushpa", Artist = "Allu Arjun", Genre = "Action", Ratings = 4},
new Movie(){Title = "Queen", Artist = "Kangana Ranaut", Genre = "Comedy", Ratings = 5},
new Movie(){Title = "Raazi", Artist = "Alia Bhatt", Genre = "Drama", Ratings = 5},
new Movie(){Title = "Stree", Artist = "Shraddha Kapoor", Genre = "Horror Comedy", Ratings = 4},
new Movie(){Title = "Zindagi Na Milegi Dobara", Artist = "Katrina Kaif", Genre = "Drama", Ratings = 5},
new Movie(){Title = "Tamasha", Artist = "Deepika Padukone", Genre = "Romance", Ratings = 4},
new Movie(){Title = "Andhadhun", Artist = "Ayushmann Khurrana", Genre = "Thriller", Ratings = 5},
new Movie(){Title = "Barfi", Artist = "Priyanka Chopra", Genre = "Drama", Ratings = 5},
new Movie(){Title = "Sultan", Artist = "Anushka Sharma", Genre = "Sports", Ratings = 4},
new Movie(){Title = "Tiger Zinda Hai", Artist = "Katrina Kaif", Genre = "Action", Ratings = 4},
new Movie(){Title = "Bhool Bhulaiyaa", Artist = "Akshay Kumar", Genre = "Comedy", Ratings = 4},
new Movie(){Title = "Yeh Jawaani Hai Deewani", Artist = "Deepika Padukone", Genre = "Romance", Ratings = 5},
new Movie(){Title = "Kesari", Artist = "Akshay Kumar", Genre = "Historical", Ratings = 4},
new Movie(){Title = "Article 15", Artist = "Ayushmann Khurrana", Genre = "Drama", Ratings = 5}


        };
        public bool AddMovie(string movieDetails)
        {
            string[] movie = movieDetails.Split(',');
            Movie m = new Movie();
            m.Title = movie[0];
            m.Artist = movie[1];
            m.Genre = movie[2];
            m.Ratings = Convert.ToInt32(movie[3]);
            MovieList.Add(m);
            return true;
        }

        public void GetMovieList()
        {
            foreach(Movie m in MovieList)
            {
                Console.WriteLine($"Title: {m.Title} , Artist: {m.Artist} , Genre: {m.Genre} , Rating: {m.Ratings}");
            }

        }

        public void ViewMoviesByGenre()
        {
            var movieByGenre = (from i in MovieList
                               group i by i.Genre).
                               ToDictionary(g => g.Key, g=> g.ToList());

            foreach(var m in movieByGenre)
            {
                Console.WriteLine($"Genre: {m.Key} -   ");
                foreach(var i in m.Value)
                {
                    Console.WriteLine($"Title: {i.Title} , Artist: {i.Artist} , Genre: {i.Genre} , Rating: {i.Ratings}");
                }
            }
        }

        public void ViewMovieByRating()
        {
            var movieByRating = (from i in MovieList
                                 group i by i.Ratings).
                                ToDictionary(g => g.Key, g => g.ToList());


            foreach (var m in movieByRating)
            {
                Console.WriteLine($"Rating: {m.Key} -   ");
                foreach (var i in m.Value)
                {
                    Console.WriteLine($"Title: {i.Title} , Artist: {i.Artist} , Genre: {i.Genre} , Rating: {i.Ratings}");
                }
            }
        }

        public void ViewMovieByArtist()
        {
             var MovieByArtist = (from i in MovieList
                                  group i by i.Artist)
                                  .ToDictionary(g => g.Key, g => g.ToList());
            foreach (var m in MovieByArtist)
            {
                Console.WriteLine($"Artist: {m.Key} -   ");
                foreach (var i in m.Value)
                {
                    Console.WriteLine($"Title: {i.Title} , Artist: {i.Artist} , Genre: {i.Genre} , Rating: {i.Ratings}");
                }
            }
        }


    }
}
