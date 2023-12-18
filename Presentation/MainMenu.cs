using DataAccess;
public class MainMenu
{
    public static void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            string cinemaLogo = @"

  /$$$$$$  /$$$$$$ /$$   /$$ /$$$$$$$$ /$$      /$$  /$$$$$$  /$$   /$$
 /$$__  $$|_  $$_/| $$$ | $$| $$_____/| $$$    /$$$ /$$__  $$| $$  / $$
| $$  \__/  | $$  | $$$$| $$| $$      | $$$$  /$$$$| $$  \ $$|  $$/ $$/
| $$        | $$  | $$ $$ $$| $$$$$   | $$ $$/$$ $$| $$$$$$$$ \  $$$$/
| $$        | $$  | $$  $$$$| $$__/   | $$  $$$| $$| $$__  $$  >$$  $$
| $$    $$  | $$  | $$\  $$$| $$      | $$\  $ | $$| $$  | $$ /$$/\  $$
|  $$$$$$/ /$$$$$$| $$ \  $$| $$$$$$$$| $$ \/  | $$| $$  | $$| $$  \ $$
 \______/ |______/|__/  \__/|________/|__/     |__/|__/  |__/|__/  |__/
                                                                       ";

            Console.WriteLine(cinemaLogo);
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine($"\nWelcome to CineMax {ActiveUser.LoggedUser?.Name}!\n");
            Console.WriteLine("\nChoose out of the following options:\n");
            Console.WriteLine("1. View available movies");
            Console.WriteLine("2. Search movies");
            Console.WriteLine("3. Purchase movie tickets");
            Console.WriteLine("4. Exit");
            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    BrowseMovieListing.Display();
                    break;
                case "2":
                    SearchMovie.SearchMoviesByName();
                    break;
                case "3":
                    Reservation.View();
                    break;
                case "4":
                    exit = true;
                    break;
            }
        }
    }
}
