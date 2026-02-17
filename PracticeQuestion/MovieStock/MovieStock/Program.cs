using MovieStock;

class Program
{
    public static void Main(string[] args)
    {
        MovieUtility obj = new MovieUtility();
        obj.AddMovie("Devdas,ShahRukhKhan,Romance,2");
        obj.ViewMovieByArtist();
        obj.ViewMoviesByGenre();
        obj.ViewMovieByRating();
        obj.GetMovieList();
    }

}
