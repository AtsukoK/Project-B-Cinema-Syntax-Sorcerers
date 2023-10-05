public class Movie
{
    public string Name;
    public string Genre;
    public string Director;
    public double Rating;
    public double Price;
    public string Duration;

    public Movie(string name, string genre, string director, double rating, double price, string duration)
    {
        Name = name;
        Genre = genre;
        Director = director;
        Rating = rating;
        Price = price;
        Duration = duration;
    }
}