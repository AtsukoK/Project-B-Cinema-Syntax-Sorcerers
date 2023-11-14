using DataAccess;

public class MovieListing
{
    public static void DisplayMovies(List<Movie> movies)
    {
        // Calculate padding for each attribute
        int indexWidth = movies.Count.ToString().Length + 2; // Om scheve display te voorkomen bij dubbele index 10+
        int titleWidth = movies.Max(m => m.Title.Length) + 2;
        int durationWidth = movies.Max(m => m.Duration.Length) + 2;
        int genreWidth = movies.Max(m => m.Genre.Length) + 2;

        for (int i = 0; i < movies.Count; i++)
        {
            string index = (i + 1).ToString().PadRight(indexWidth);
            string title = movies[i].Title.PadRight(titleWidth);
            string duration = movies[i].Duration.PadRight(durationWidth);
            string genre = movies[i].Genre.PadRight(genreWidth);
            Console.WriteLine($"{index}{title}| {duration}| {genre}");
        }
    }

    public static void DisplayMovieDetails(Movie movie)
    {
        Console.Clear();
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Duration: {movie.Duration}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Description: {movie.Description}");
        Console.WriteLine($"Rating: {movie.Rating}");
        Console.WriteLine($"Showtimes: {movie.Showtimes}");
        Console.WriteLine($"Cast: {movie.Cast}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine($"Ticket Price: ${movie.Price}");
        Console.WriteLine("\nPress 'ENTER' to return to the movie list, or enter 'M' to return directly to the main menu...");
    }
}

public static class BrowseMovieListing
{
    public static void Display()
    {
        bool returnToMainMenu = false;
        while (!returnToMainMenu)
        {
            Console.Clear();
            Console.WriteLine("Movie Listings:");
            List<Movie> movies = AccessData.ReadMoviesJson();
            MovieListing.DisplayMovies(movies);

            Console.WriteLine("\nSelect a movie number to view details, press 'ENTER' to refresh the movie list, or enter 'M' to return directly to the main menu...");
            string movieChoice = Console.ReadLine();
            Console.Clear();

            if (!string.IsNullOrEmpty(movieChoice) && movieChoice.ToUpper() != "M" && int.TryParse(movieChoice, out int movieIndex) && movieIndex > 0 && movieIndex <= movies.Count)
            {
                MovieListing.DisplayMovieDetails(movies[movieIndex - 1]);
                movieChoice = Console.ReadLine();
                Console.Clear();

                // If they decide to directly return to the main menu
                if (movieChoice.ToUpper() == "M")
                {
                    Console.Clear(); // Clear console before returning to main menu.
                    returnToMainMenu = true;
                }
            }
            else if (string.IsNullOrEmpty(movieChoice) || movieChoice.ToUpper() == "M")
            {
                Console.Clear();  //Clear console before returning to de main menu.
                returnToMainMenu = true;
            }
        }
    }
}
