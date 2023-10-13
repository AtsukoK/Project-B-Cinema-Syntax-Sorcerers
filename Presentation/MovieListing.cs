using DataAccess;


public class MovieListing
{
    public static void DisplayMovies(List<Movie> movies)
    {
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {movies[i].Title} | {movies[i].Duration} | {movies[i].Genre}");
        }
    }

    public static void DisplayMovieDetails(Movie movie)
    {
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Duration: {movie.Duration}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Description: {movie.Description}");
        Console.WriteLine($"Rating: {movie.Rating}");
        Console.WriteLine($"Showtimes: {movie.Showtimes}");
        Console.WriteLine($"Cast: {movie.Cast}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine($"Ticket Price: ${movie.Price}");
    }
}

public static class BrowseMovieListing
{
    public static void Display()
    {
        bool returnToMainMenu = false;
        while (!returnToMainMenu)
        {
            Console.WriteLine("Movie Listings:");
            List<Movie> movies = AccessData.ReadMoviesJson(); 
            MovieListing.DisplayMovies(movies);

            Console.WriteLine("\nSelect a movie number to view details, press 'ENTER' to refresh the movie list, or enter 'M' to return directly to the main menu...");
            string movieChoice = Console.ReadLine();

            if (!string.IsNullOrEmpty(movieChoice) && movieChoice.ToUpper() != "M" && int.TryParse(movieChoice, out int movieIndex) && movieIndex > 0 && movieIndex <= movies.Count)
            {
                MovieListing.DisplayMovieDetails(movies[movieIndex - 1]);
                Console.WriteLine("\nPress 'ENTER' to return to the movie list, or enter 'M' to return directly to the main menu...");
                movieChoice = Console.ReadLine();

                // If they decide to directly return to the main menu
                if (movieChoice.ToUpper() == "M")
                {
                    returnToMainMenu = true;
                }
            }
            else if (string.IsNullOrEmpty(movieChoice) || movieChoice.ToUpper() == "M")
            {
                returnToMainMenu = true;
            }
        }
    }
}
