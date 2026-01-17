using MovieStack;
using System;
class Program
{
    public static void Main(string [] args)
    {
        MovieInfo movieStack = new MovieInfo();
        Movie newmovie = new Movie();
        Console.WriteLine("Enter Movie Name");
        newmovie.Title = Console.ReadLine();
        Console.WriteLine("Enter Movie Artist");
        newmovie.Artist = Console.ReadLine();
        Console.WriteLine("Enter Movie Genre");
        newmovie.Genre = Console.ReadLine();
        Console.WriteLine("Enter Movie Ratings");
        newmovie.Ratings = Int32.Parse(Console.ReadLine());

        movieStack.AddMovie(newmovie);

        //foreach (Movie movie in movieStack)
        //{
        //    Console.WriteLine($"{ movie.Title} , { movie.Genre }, { movie.Ratings} , { movie.Artist}");
        //}


        Console.WriteLine("Enter Movie Genre you want to seacrh for");
        string gen = Console.ReadLine();

        foreach(Movie m in movieStack.ViewMoviesByGenre(gen))
        {
            Console.WriteLine($"{m.Title} , {m.Genre}, {m.Ratings} , {m.Artist}");

        }

        Console.WriteLine("Movie Rating ");
        

        foreach (Movie m in movieStack.ViewMoviesByRatings())
        {
            Console.WriteLine($"{m.Title} , {m.Genre}, {m.Ratings} , {m.Artist}");

        }






    }
}