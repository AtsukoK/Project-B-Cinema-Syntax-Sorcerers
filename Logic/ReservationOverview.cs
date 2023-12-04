using DataAccess;
using Newtonsoft.Json.Linq;
class Reservation

{
    private static int hallDisplayCounter = 0;
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
                            Console.WriteLine("Enter the number of the chair you want to reserve: ");
                            string selectedChairId = Console.ReadLine()!;

                            if (ReserveChair(show, selectedChairId, movie))
                            {
                                HallDisplay.DisplayHall(show);
                            }
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

    public static bool ReserveChair(Show show, string chairId, Movie movie)
    {
        List<Chair> allChairs = show.Chairs;

        if (allChairs != null)
        {
            Chair selectedChair = allChairs.Find(chair => chair.ID == int.Parse(chairId))!;

            if (selectedChair != null && !selectedChair.IsReserved)
            {
                selectedChair.IsReserved = true;
                Console.WriteLine($"Chair {selectedChair.ID} reserved successfully!");

                if (movie != null)
                {
                    double totalCost = movie.Price * selectedChair.Price;
                    string formattedNumber = totalCost.ToString("F2");
                    Console.WriteLine($"\nTotal Cost: {formattedNumber}\n");

                    if (hallDisplayCounter == 0)
                    {
                        HallDisplay.DisplayHall(show);
                        hallDisplayCounter++;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Movie information not available.");
                }

                return true;
            }
        }

        Console.WriteLine("Chair not found or already reserved.");
        return false;
    }
}