using Newtonsoft.Json;
namespace DataAccess
{
    public class AccessPersonData
    {
        public static List<Person> ReadPersonJson()
        {
            string jsonFilePath = Path.Combine("Datasources", "Person.json"); // Datasource/Person.json
            string ExistingJsonPersonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]"; //replace person.json with actual file path
            List<Person> PersonList = JsonConvert.DeserializeObject<List<Person>>(ExistingJsonPersonData);
            return PersonList;
        }
        public static List<Movie> ReadMoviesJson()
        {
            string jsonFilePath = Path.Combine("Datasources", "MovieDataSource.json"); // Datasource/Movie.json
            string ExistingJsonPersonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]";
            List<Movie> MovieList = JsonConvert.DeserializeObject<List<Movie>>(ExistingJsonPersonData);
            return MovieList;
        }
    }
}
