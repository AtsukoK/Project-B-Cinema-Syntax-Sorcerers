using Newtonsoft.Json.Linq;
using DataAccess;
class TicketPrices
{
    public static void View()
    {
        List<Movie> movies = AccessData.ReadMoviesJson();
        string filePath = Path.Combine("Datasources", "MovieDataSource.json");

        try
        {
            string jsonData = File.ReadAllText(filePath);

            JArray data = JArray.Parse(jsonData); // parses json into array

            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Title}");

                foreach (JObject obj in data)
                {
                    if (movie.Title == (string)obj["title"]!)
                    {
                        double moviePrice = (double)obj["price"]!;
                        string formattedNumber = moviePrice.ToString("F2");
                        Console.WriteLine($"Ticket price: ${formattedNumber}\n");
                        break; // exit the inner loop once the price is found
                    }
                }
            }
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Error: {ex.Message}"); // if the file is not found a message will show up
        }
    }
}