// See https://aka.ms/new-console-template for more information


using Conproject;

public class Program
{
    public static void Main(string[] args)
    {
        Movies movies = new Movies();
        movies.GetMovies();
        movies.GetMoviesByTitle("Leo");

        Console.ReadKey();
    }

}

