using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conproject
{
    internal class Movies
            {
            public int MovieId { get; set; }
            public string? Title { get; set; }
            public string? Genre { get; set; }

            public static List<Movies> movies = new List<Movies>()
        {
            new Movies() {MovieId=1,Title="Leo",Genre="Action"},
            new Movies() {MovieId=2,Title="The Conjuring",Genre="Horror"},
            new Movies() {MovieId=3,Title="KGF",Genre="Action"},
            new Movies() {MovieId=4,Title="Home Alone",Genre="Comedy"},
            new Movies() {MovieId=5,Title="Zodiac",Genre="Crime Thriller"}
        };
            public void GetMovies()
            {
                Console.WriteLine("All Movies:");
                Console.Write("Id \t\t Title \t\t Genre \n");
                foreach (var movie in movies)
                {
                    Console.Write(movie.MovieId + "\t \t");
                    Console.Write(movie.Title + "\t \t");
                    Console.Write(movie.Genre);
                    Console.WriteLine("\n");
                }

            }
            public void GetMoviesByTitle(string title)
            {
                Console.WriteLine($"Movies By Name {title}:");
                Console.Write("Id \t\t Title \t\t Genre \n");

                foreach (var movie in movies)
                {
                    if (movie.Title == title)
                    {
                        Console.Write(movie.MovieId + "\t \t");
                        Console.Write(movie.Title + "\t \t");
                        Console.Write(movie.Genre);
                        Console.WriteLine("\n");
                    }
                }

            }
        }
    }

