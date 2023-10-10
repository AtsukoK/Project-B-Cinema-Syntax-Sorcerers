using Newtonsoft.Json;

public class AccessMovieData
{
    public static List<Movie> ReadMoviesJson()
    {
        string jsonFilePath = Path.Combine("Datasources", "MovieDataSource.json"); // Datasource/Movie.json
        string ExistingJsonPersonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]"; //replace person.json with actual file path
        List<Movie> MovieList = JsonConvert.DeserializeObject<List<Movie>>(ExistingJsonPersonData);
        return MovieList;
    }
}
