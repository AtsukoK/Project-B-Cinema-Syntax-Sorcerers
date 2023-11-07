namespace DataAccess
{
    public class SearchMovie
    {
        public static void SearchMoviesByName()
        {
            Console.WriteLine("Enter the name or part of the name of the movie you're looking for:");
            string movieName = Console.ReadLine();

            if (movieName is not null)
            {
                List<Movie> allMovies = AccessData.ReadMoviesJson();
                List<Movie> matchingMovies = SearchMovies(allMovies, movieName);

                if (matchingMovies.Count > 0)
                {
                    Console.WriteLine("Matching Movies:");
                    foreach (Movie movie in matchingMovies)
                    {
                        Console.WriteLine($"Title: {movie.Title}");
                        Console.WriteLine("Do you want to see the movie details? (Y/N)");
                        string input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            Console.WriteLine($"Price: {movie.Price}");
                            Console.WriteLine($"Duration: {movie.Duration}");
                            Console.WriteLine($"Genre: {movie.Genre}");
                            Console.WriteLine($"Cast: {string.Join(", ", movie.Cast)}");
                            Console.WriteLine($"Director: {movie.Director}");
                            Console.WriteLine($"Description: {movie.Description}");
                            Console.WriteLine($"Rating: {movie.Rating}");
                        }

                        if (movie.IsPlaying)
                        {
                            Console.WriteLine($"Showtimes: {movie.Showtimes}");
                        }
                        else
                        {
                            Console.WriteLine($"{movie.Title} is currently not playing.");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No matching movies found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("Do you want to return to the main menu? (Y/N)");
            string returnInput = Console.ReadLine().ToLower();
            if (returnInput == "y")
            {
                MainMenu.Start();
            }
        }
        // niet gelukt om de main niet te laten zien als user n invoert

        private static List<Movie> SearchMovies(List<Movie> movies, string searchTerm)
        {
            List<Movie> matchingMovies = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.Title.ToLower().Contains(searchTerm.ToLower()))
                {
                    matchingMovies.Add(movie);
                }
            }
            return matchingMovies;
        }


    }
}
