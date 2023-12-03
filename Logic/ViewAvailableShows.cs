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
                Console.WriteLine("\nTicket Prices");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Economy Seats     [Blue]: {MovieObject.Price}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Pro Seats       [Yellow]: {Math.Round(MovieObject.Price * 1.05, 2)}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Vip Seats          [Red]: {Math.Round(MovieObject.Price * 1.10, 2)}");
                Console.ResetColor();
                Console.WriteLine();
                IndexNumber++;
                HallDisplay.DisplayHall(show);
            }
        }
    }
}