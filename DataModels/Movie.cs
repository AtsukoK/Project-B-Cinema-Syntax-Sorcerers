public class Movie
{
    public string Title;
    public string Genre;
    public string Director;
    public double Rating;
    public double Price;
    public string Duration;

    public Movie(string title, string genre, string director, double rating, double price, string duration)
    {
        Title = title;
        Genre = genre;
        Director = director;
        Rating = rating;
        Price = price;
        Duration = duration;
    }
}