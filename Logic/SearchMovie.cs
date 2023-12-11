namespace DataAccess
{
    public class SearchMovie
    {
        public static void SearchMoviesByName()
        {
            Console.WriteLine("Enter the name or part of the name of the movie you're looking for:");
            string movieName = Console.ReadLine();

            if (movieName is not null) // if movieName is not null, continue
            {
                List<Movie> allMovies = AccessData.ReadMoviesJson();
                List<Movie> matchingMovies = SearchMovies(allMovies, movieName);

                if (matchingMovies.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Matching Movies:");
                    for (int i = 0; i < matchingMovies.Count; i++) // loop through matchingMovies and display the title of each movie in a list
                    {
                        Console.WriteLine($"{i + 1}. {matchingMovies[i].Title}");
                    }

                    Console.WriteLine("Enter the number of the movie you want to see details (or 'n' to return to the main menu):");
                    string input = Console.ReadLine().ToLower();

                    if (input != "n" && int.TryParse(input, out int selectedIndex) && selectedIndex >= 1 && selectedIndex <= matchingMovies.Count)
                    // if input is not 'n' and is a number between 1 and the number of matching movies, continue
                    {
                        Movie selectedMovie = matchingMovies[selectedIndex - 1];
                        DisplayMovieDetails(selectedMovie);
                    }
                    else if (input == "n")
                    {
                        Console.WriteLine("Returning to the main menu.");
                        MainMenu.Start();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Returning to the main menu.");
                        MainMenu.Start();
                    }
                }
                else
                {
                    Console.WriteLine("No matching movies found.");
                    ReturnToMainMenu();
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                ReturnToMainMenu();
            }
        }

        private static void DisplayMovieDetails(Movie movie)
        {
            Console.Clear();
            Console.WriteLine($"Title: {movie.Title}");
            Console.WriteLine($"Price: {movie.Price}");
            Console.WriteLine($"Duration: {movie.Duration}");
            Console.WriteLine($"Genre: {movie.Genre}");
            Console.WriteLine($"Cast: {string.Join(", ", movie.Cast)}");
            Console.WriteLine($"Director: {movie.Director}");
            Console.WriteLine($"Description: {movie.Description}");
            Console.WriteLine($"Rating: {movie.Rating}");

            Console.WriteLine("Do you want to view information about another movie? (y/n)");
            string viewAnotherInput = Console.ReadLine().ToLower();

            if (viewAnotherInput == "y")
            {
                SearchMoviesByName(); // go back to search movies again
            }
            else if (viewAnotherInput == "n")
            {
                ReturnToMainMenu(); // return to the main menu
            }
            else
            {
                Console.WriteLine("Invalid input. Returning to the main menu.");
                MainMenu.Start(); // return to the main menu on invalid input
            }
        }


        private static void ReturnToMainMenu()
        {
            Console.WriteLine("Do you want to return to the main menu? (y/n)");
            string returnInput = Console.ReadLine().ToLower();

            if (returnInput == "y")
            {
                MainMenu.Start();
            }
            else if (returnInput == "n")
            {
                Console.WriteLine("Leaving the program, bye!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input. Returning to the main menu.");
                MainMenu.Start();
            }
        }

        private static List<Movie> SearchMovies(List<Movie> movies, string searchTerm)
        {
            List<Movie> matchingMovies = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.Title.ToLower().Contains(searchTerm.ToLower()) || movie.Genre.ToLower().Contains(searchTerm.ToLower()))
                {
                    matchingMovies.Add(movie);
                }
            }
            return matchingMovies; // returns a list of movies that match the search term
        }

    }
}
