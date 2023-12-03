using DataAccess;

class Viewer
{
    public static void ViewShows(String UserInp)
    {
        Console.Clear();
        List<Show> Shows = AccessData.ReadShowsJson();
        List<Movie> MovieObjects = AccessData.ReadMoviesJson();

        Console.WriteLine($"Select Movie:{UserInp}");
        int IndexNumber = 1;
        Movie MovieObject = null;

        foreach (Movie movie in MovieObjects)
        {
            if (UserInp == movie.Title)
            {
                MovieObject = movie;
                break;
            }
        }

        foreach (Show show in Shows)
        {

            if (show.Moviename == UserInp)
            {
                Console.WriteLine($"[SHOW {IndexNumber}] Start at {show.MovieStartDate}                   End at {show.MovieEndDate}");
                Console.WriteLine("Ticket Prices");
                Console.WriteLine($"Economy Seats[Blue]: {MovieObject.Price}");
                Console.WriteLine($"Pro Seats  [Yellow]: {MovieObject.Price * 1.05}");
                Console.WriteLine($"Vip Seats     [Red]: {MovieObject.Price * 1.10}");
                IndexNumber++;
                HallDisplay.DisplayHall(show);
            }
        }
    }
}