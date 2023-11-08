using MovieRepository;

public static class MovieEditDisplay
{
    private static MovieEditLogic _movieEditLogic = new MovieEditLogic(new RepositoryMovie());

    public static void EditMovieInfo()
    {
        Console.Clear();
        var movies = _movieEditLogic.GetMovies();
        DisplayMoviesWithIds(movies);

        Console.WriteLine("Enter the number of the movie you wish to edit:");
        if (int.TryParse(Console.ReadLine(), out int movieNumber) && movieNumber >= 1 && movieNumber <= movies.Count)
        {
            Console.Clear();
            int index = movieNumber - 1;
            var movieToEdit = movies[index];
            bool backToAdminMenu = false;

            DisplayEditDetails(movieToEdit);
            
            while (!backToAdminMenu)
            {
                Console.WriteLine($"Selected Movie: '{movieToEdit.Title}'. What would you like to edit?");
                Console.WriteLine("1: Title\n2: Genre\n3: Description\n4: Rating\n5: Showtimes\n6: Cast\n7: Director\n8: Ticket Price\n9: Is Playing\nM: Return to Admin Menu");
                var editChoice = Console.ReadLine();
                
                switch (editChoice)
                {
                    case "1":
                        UpdateField("title", newValue => movieToEdit.Title = newValue);
                        break;
                    case "2":
                        UpdateField("genre", newValue => movieToEdit.Genre = newValue);
                        break;
                    case "3":
                        UpdateField("description", newValue => movieToEdit.Description = newValue);
                        break;
                    case "4":
                        UpdateFieldForDouble("rating", newValue => movieToEdit.Rating = Convert.ToDouble(newValue));
                        break;
                    case "5":
                        UpdateField("showtimes", newValue => movieToEdit.Showtimes = newValue);
                        break;
                    case "6":
                        UpdateField("cast", newValue => movieToEdit.Cast = newValue);
                        break;
                    case "7":
                        UpdateField("director", newValue => movieToEdit.Director = newValue);
                        break;
                    case "8":
                        UpdateFieldForDouble("ticket price", newValue => movieToEdit.Price = Convert.ToDouble(newValue));
                        break;
                    case "9":
                        UpdateFieldForBool("is playing", newBoolValue => movieToEdit.IsPlaying = newBoolValue);
                        break;
                    case "M":
                    case "m":
                        Console.Clear();
                        backToAdminMenu = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (!backToAdminMenu)
                {
                    Console.WriteLine("Would you like to edit another field? (yes/no):");
                    string editMore = Console.ReadLine();
                    if(editMore.Trim().Equals("no", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear(); //Clear the console after each edit.
                    }
                    backToAdminMenu = !editMore.Trim().Equals("yes", StringComparison.OrdinalIgnoreCase);
                }
            }

            _movieEditLogic.EditMovieInformation(index, movieToEdit);
            Console.WriteLine("All changes saved successfully.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private static void DisplayMoviesWithIds(List<Movie> movies)
    {
        for (int i = 0; i < movies.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {movies[i].Title}");
        }
    }

    private static void DisplayEditDetails(Movie movie)
    {
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Description: {movie.Description}");
        Console.WriteLine($"Rating: {movie.Rating}");
        Console.WriteLine($"Showtimes: {movie.Showtimes}");
        Console.WriteLine($"Cast: {movie.Cast}");
        Console.WriteLine($"Director: {movie.Director}");
        Console.WriteLine($"Ticket Price: {movie.Price}");
        Console.WriteLine($"Is Playing: {(movie.IsPlaying ? "Yes" : "No")}");
        Console.WriteLine("\nWhat would you like to edit?");
    }

    private static void UpdateField(string fieldName, Action<string> updateAction)
    {
        Console.WriteLine($"Enter new {fieldName}:");
        string newValue = Console.ReadLine();
        if (!string.IsNullOrEmpty(newValue))
        {
            updateAction(newValue);
        }
    }

    private static void UpdateFieldForDouble(string fieldName, Action<double> updateAction)
    {
        Console.WriteLine($"Enter new {fieldName} (number expected):");
        if (double.TryParse(Console.ReadLine(), out double newDoubleValue))
        {
            updateAction(newDoubleValue);
        }
        else
        {
            Console.WriteLine("Invalid input for a number.");
        }
    }

    private static void UpdateFieldForBool(string fieldName, Action<bool> updateAction)
{
    Console.WriteLine($"Is the movie {fieldName}? (yes/no):");
    string newValue = Console.ReadLine();
    updateAction(newValue.Trim().Equals("yes", StringComparison.OrdinalIgnoreCase));
}
}