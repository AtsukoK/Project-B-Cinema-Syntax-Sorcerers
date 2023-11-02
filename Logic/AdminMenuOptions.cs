using DataAccess;
using Newtonsoft.Json;
using System.Collections.Generic;
class AdminOptions
{
    public static void AddMovies()
    {
        string dataFolderPath = "DataSources";
        string jsonFilePath = Path.Combine(dataFolderPath, "MovieDataSource.json");

        string json = File.ReadAllText(jsonFilePath);

        List<dynamic> movies = JsonConvert.DeserializeObject<List<dynamic>>(json)!;

        var newMovie = new
        {
            title = ReadUserInput("Title: "),
            duration = ReadUserInput("Duration : "),
            genre = ReadUserInput("Genre: "),
            description = ReadUserInput("Description: "),
            rating = ReadUserInput("Rating: "),
            showtimes = ReadUserInput("Showtimes: "),
            cast = ReadUserInput("Cast: "),
            director = ReadUserInput("Director: "),
            price = double.Parse(ReadUserInput("Price: ")),
            IsPlaying = true
        };

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
        List<dynamic> movies = AccessData.JsonObjList();
        Console.WriteLine("Enter movie title to remove: ");
        string adminPrompt = Console.ReadLine()!;

        bool movieRemoved = false;

        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i]["title"] == adminPrompt)
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
        string jsonFilePath = AccessData.GetMoviesJsonFilePath();

        File.WriteAllText(jsonFilePath, updatedJson);

    }



    public static void EditTicketPrices()
    {
        List<dynamic> movies = AccessData.JsonObjList();

        Console.WriteLine("Enter movie title to change price: ");
        string adminTitle = Console.ReadLine()!;
        bool priceChanged = false;

        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i]["title"] == adminTitle)
            {
                Console.WriteLine("New price:");
                double newPrice = Convert.ToDouble(Console.ReadLine());

                movies[i]["price"] = newPrice;
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
        string jsonFilePath = AccessData.GetMoviesJsonFilePath();

        File.WriteAllText(jsonFilePath, updatedJson);
    }
}