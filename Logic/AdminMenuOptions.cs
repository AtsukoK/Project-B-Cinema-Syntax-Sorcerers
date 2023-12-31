using DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

class AdminOptions
{
    static string MoviesJsonFilePath = Path.Combine("DataSources", "MovieDataSource.json");

    public static void AddMovies()
    {
        List<Movie> movies = AccessData.ReadMoviesJson();

        var newMovie = new Movie(
            ReadUserInput("Title: "),
            ReadUserInput("Genre: "),
            ReadUserInput("Director: "),
            double.Parse(ReadUserInput("Rating: ")),
            double.Parse(ReadUserInput("Price: ")),
            ReadUserInput("Duration : "),
            ReadUserInput("Description: "),
            ReadUserInput("Showtimes: "),
            ReadUserInput("Cast: "),
            true
        );

        movies.Add(newMovie);

        string updatedJson = JsonConvert.SerializeObject(movies, Formatting.Indented);

        File.WriteAllText(MoviesJsonFilePath, updatedJson);

        Console.WriteLine("\nMovie successfully added!\n");
    }


    private static string ReadUserInput(string userPrompt)
    {
        Console.Write(userPrompt);
        return Console.ReadLine()!;
    }

    public static void RemoveMovies()
    {
        List<Movie> movies = AccessData.ReadMoviesJson();
        List<Show> shows = AccessData.ReadShowsJson();
        Console.Clear();
        foreach (Movie mov in movies)
        {
            Console.WriteLine(mov.Title);
        }

        Console.WriteLine("\nEnter movie title to remove: ");
        string adminPrompt = Console.ReadLine()!;
        bool removMovie = false;

        Movie? movieToRemove = movies.Find(movie => movie.Title == adminPrompt);

        if (movieToRemove != null)
        {
            removMovie = true;
            movies.Remove(movieToRemove);
            Console.WriteLine("Movie removed successfully.");
            Thread.Sleep(1500);
        }
        else
        {
            Console.WriteLine("Movie not found.");
            Thread.Sleep(1500);
        }

        string updatedJson = JsonConvert.SerializeObject(movies, Formatting.Indented);
        File.WriteAllText(MoviesJsonFilePath, updatedJson);
        List<Show> showsToRemove = shows.Where(show => show.Moviename == adminPrompt).ToList();
        foreach (var showToRemove in showsToRemove)
        {
            shows.Remove(showToRemove);
            Console.WriteLine($"Show for {adminPrompt} removed successfully.");
            Thread.Sleep(1500);
        }

        if (removMovie)
        {
            string moviesJson = JsonConvert.SerializeObject(movies, Formatting.Indented);
            File.WriteAllText(Path.Combine("Datasources", "MovieDataSource.json"), moviesJson);

            string showsJson = JsonConvert.SerializeObject(shows, Formatting.Indented);
            File.WriteAllText(Path.Combine("Datasources", "ShowList.json"), showsJson);
        }
    }

    public static void EditTicketPrices()
    {
        List<Movie> movies = AccessData.ReadMoviesJson();
        Console.Clear();
        Console.WriteLine("Available movies:\n");
        foreach (Movie mov in movies)
        {
            Console.WriteLine(mov.Title);
        }
        Console.WriteLine("\nEnter movie title to change price: ");
        string adminTitle = Console.ReadLine()!;
        bool priceChanged = false;

        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Title == adminTitle)
            {
                Console.WriteLine("New price:");
                double newPrice = Convert.ToDouble(Console.ReadLine());

                movies[i].Price = newPrice;
                priceChanged = true;
                Console.WriteLine("Price changed successfully");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
        }

        if (!priceChanged)
        {
            Console.WriteLine("Movie not found.");
        }

        string updatedJson = JsonConvert.SerializeObject(movies, Formatting.Indented);
        File.WriteAllText(MoviesJsonFilePath, updatedJson);
    }
}
