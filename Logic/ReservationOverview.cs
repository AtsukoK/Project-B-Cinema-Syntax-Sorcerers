using DataAccess;
using Newtonsoft.Json.Linq;
class Reservation

{
    public static void View()
    {

        Console.WriteLine("Enter movie title: ");
        string movieTitle = Console.ReadLine()!;
        List<Movie> movies = AccessData.ReadMoviesJson();
        List<Show> Shows = AccessData.ReadShowsJson();
        string filePath = Path.Combine("Datasources", "MovieDataSource.json");

        try
        {
            string jsonData = File.ReadAllText(filePath);

            JArray data = JArray.Parse(jsonData); // parses json into array

            bool movieFound = false;

            foreach (var movie in movies)
            {
                foreach (JObject obj in data)
                {
                    string title = (string)obj["title"]!;

                    foreach (Show show in Shows)
                    {
                        if (show.Moviename == title)
                        {
                            Viewer.ViewShows(movieTitle);
                            movieFound = true;
                            break;
                        }
                    }
                }

                if (movieFound)
                {
                    break; // exit outer loop when movie is found
                }
            }

            if (!movieFound)
            {
                Console.WriteLine("Movie not available.");
            }
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}"); // if the file is not found a message will show up
        }

    }
}