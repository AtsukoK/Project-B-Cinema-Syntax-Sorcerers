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
}