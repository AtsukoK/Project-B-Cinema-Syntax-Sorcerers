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
