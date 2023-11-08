using Newtonsoft.Json;

namespace MovieRepository
{
    public class RepositoryMovie
    {
        private static string dataFolderPath = "DataSources";
        private static string jsonFilePath = Path.Combine(dataFolderPath, "MovieDataSource.json");

        public List<Movie> GetMovies()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonData = File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<List<Movie>>(jsonData) ?? new List<Movie>();
            }
            return new List<Movie>();
        }

        public void SaveMovies(List<Movie> movies)
        {
            string jsonData = JsonConvert.SerializeObject(movies, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);
        }
    }
}