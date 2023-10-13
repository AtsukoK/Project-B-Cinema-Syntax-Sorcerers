public class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public double Rating { get; set; }
    public double Price { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
    public string Showtimes { get; set; }  
    public string Cast { get; set; }       
    public bool IsPlaying { get; set; }    

    public Movie(string title, string genre, string director, double rating, double price, string duration, string description, string showtimes, string cast, bool isPlaying)
    {
        Title = title;
        Genre = genre;
        Director = director;
        Rating = rating;
        Price = price;
        Duration = duration;
        Description = description;
        Showtimes = showtimes;
        Cast = cast;
        IsPlaying = isPlaying;
    }
}
