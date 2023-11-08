using MovieRepository;

public class MovieEditLogic
{
    private readonly RepositoryMovie _movieRepository;

    public MovieEditLogic(RepositoryMovie movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public List<Movie> GetMovies()
    {
        return _movieRepository.GetMovies();
    }

    // This method now accepts the index of the movie in the list
    public void EditMovieInformation(int index, Movie updatedMovieInfo)
    {
        var movies = _movieRepository.GetMovies();

        // Replace the old movie with the updated one
        movies[index] = updatedMovieInfo;

        _movieRepository.SaveMovies(movies);
        Console.WriteLine("Movie information updated successfully.");
    }
}