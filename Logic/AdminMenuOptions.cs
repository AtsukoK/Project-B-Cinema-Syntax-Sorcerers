using DataAccess;
using Newtonsoft.Json;
using System.Collections.Generic;
class AdminOptions
{
    public static void AddMovies()
    {
        string jsonFilePath;
        List<Movie> movies = AccessData.ReadMoviesJson(out jsonFilePath);

        var newMovie = new Movie(
            ReadUserInput("Title: "),
            ReadUserInput("Genre: "),
            ReadUserInput("Director: "),
            double.Parse(ReadUserInput("Rating: ")),
            double.Parse(ReadUserInput("Price: ")),
            ReadUserInput("Duration: "),
            ReadUserInput("Description: "),
            ReadUserInput("Showtimes: "),
            ReadUserInput("Cast: "),
            true
        );

        movies.Add(newMovie);

        string updatedJson = JsonConvert.SerializeObject(movies, Formatting.Indented);

        File.WriteAllText(jsonFilePath, updatedJson);

        Console.WriteLine("\nMovie successfully added!\n");
    }

    private static string ReadUserInput(string userPrompt)
    {
        Console.Write(userPrompt);
        return Console.ReadLine()!;
    }



    public static void RemoveMovies()
    {
        string jsonFilePath;
        List<Movie> movies = AccessData.ReadMoviesJson(out jsonFilePath);

        Console.WriteLine("Enter movie title to remove: ");
        string adminPrompt = Console.ReadLine()!;

        bool movieRemoved = false;

        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Title == adminPrompt)
            {
                movies.RemoveAt(i);
                movieRemoved = true;
                Console.WriteLine("Movie removed successfully.");
                break;
            }
        }

        if (!movieRemoved)
        {
            Console.WriteLine("Movie not found.");
        }

        string updatedJson = JsonConvert.SerializeObject(movies, Formatting.Indented);
        File.WriteAllText(jsonFilePath, updatedJson);
    }






    public static void EditTicketPrices()
    {
        string jsonFilePath;
        List<Movie> movies = AccessData.ReadMoviesJson(out jsonFilePath);

        Console.WriteLine("Enter movie title to change price: ");
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
                break;
            }
        }

        if (!priceChanged)
        {
            Console.WriteLine("Movie not found.");
        }

        string updatedJson = JsonConvert.SerializeObject(movies, Formatting.Indented);
        File.WriteAllText(jsonFilePath, updatedJson);
    }

}