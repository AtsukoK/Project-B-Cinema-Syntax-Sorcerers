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
        public static List<Movie> ReadMoviesJson()
        {
            string jsonFilePath = Path.Combine("Datasources", "MovieDataSource.json"); // Datasource/Movie.json
            string ExistingJsonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]";
            List<Movie> MovieList = JsonConvert.DeserializeObject<List<Movie>>(ExistingJsonData);
            return MovieList;
        }

        public static List<Show> ReadShowsJson()
        {
            string jsonFilePath = Path.Combine("Datasources", "ShowList.json"); // Datasource/Movie.json
            string ExistingJsonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]";
            List<Show> ShowList = JsonConvert.DeserializeObject<List<Show>>(ExistingJsonData);
            return ShowList;
        }

        public static Person GetUserByEmail(string email)
        {
            List<Person> users = ReadPersonJson();
            return users.FirstOrDefault(u => u.Email == email);
        }

        public static void RefreshActiveUserData()
        {
            if (ActiveUser.LoggedUser != null)
            {
                ActiveUser.LoggedUser = GetUserByEmail(ActiveUser.LoggedUser.Email);
            }
        }
        
        public static void SyncUserWithJsonFile(Person updatedUser)
        {
            List<Person> users = ReadPersonJson();

            int index = users.FindIndex(u => u.Email == updatedUser.Email);
            if (index != -1)
            {
                // Update the existing user
                users[index] = updatedUser;
            }
            else
            {
                // Add new user if not found
                users.Add(updatedUser);
            }

            // Write the updated list back to the JSON file
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            string jsonFilePath = Path.Combine("Datasources", "Person.json");
            File.WriteAllText(jsonFilePath, json);
        }
    }
}
