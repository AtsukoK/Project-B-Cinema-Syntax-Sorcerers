class AdminMenuDisplay
{
    public static void View()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Administrator Menu\n");
            Console.WriteLine("Choose out of the following options:");
            Console.WriteLine("1. Add movies");
            Console.WriteLine("2. Schedule movies");
            Console.WriteLine("3. Delete movies");
            Console.WriteLine("4. Edit ticket prices");
            Console.WriteLine("5. Edit movie information");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    AdminOptions.AddMovies();
                    break;
                case "2":
                    // method for movie scheduling should go here
                    Schedule.CreateShow();
                    break;
                case "3":
                    AdminOptions.RemoveMovies();
                    break;
                case "4":
                    AdminOptions.EditTicketPrices();
                    break;
                case "5":
                    MovieEditDisplay.EditMovieInfo();
                    break;
                case "6":
                    exit = true;
                    break;
            }
        }
    }
}