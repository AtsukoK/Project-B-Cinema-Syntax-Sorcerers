using DataAccess;
public class MainMenu
{
    public static void Start()
    {
        bool exit = false;

        while (!exit)
        {
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
            Console.WriteLine("\nWelcome to CineMax!\n");
            Menu.LoginMenu();
            Console.WriteLine("\nChoose out of the following options:\n");
            Console.WriteLine("1. View available movies");
            Console.WriteLine("2. Search movies");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    BrowseMovieListing.Display();
                    break;
                case "2":
                    SearchMovie.SearchMoviesByName(); // nog niet af
                    break;
                case "3":
                    exit = true;
                    break;
            }
        }
    }
}
