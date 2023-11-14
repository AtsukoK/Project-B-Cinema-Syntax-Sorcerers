using Newtonsoft.Json;
namespace DataAccess
{
    public class AccessData
    {
        public static List<Person> ReadPersonJson()
        {
            string jsonFilePath = Path.Combine("Datasources", "Person.json"); // Datasource/Person.json
            string ExistingJsonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]"; //replace person.json with actual file path
            List<Person> PersonList = JsonConvert.DeserializeObject<List<Person>>(ExistingJsonData);
            return PersonList;
        }
        public static List<Movie> ReadMoviesJson(out string jsonFile)
        {
            string jsonFilePath = Path.Combine("Datasources", "MovieDataSource.json"); // Datasource/Movie.json
            jsonFile = jsonFilePath;
            string ExistingJsonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]";
            List<Movie> MovieList = JsonConvert.DeserializeObject<List<Movie>>(ExistingJsonData);
            return MovieList;
        }
    }
}
