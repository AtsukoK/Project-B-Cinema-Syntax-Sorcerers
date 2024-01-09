class AdminMenuDisplay
{
    public static void View()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Administrator Menu\n");
            Console.WriteLine("Choose out of the following options:");
            Console.WriteLine("1. Add movies");
            Console.WriteLine("2. Schedule movies");
            Console.WriteLine("3. Delete movies");
            Console.WriteLine("4. Edit ticket prices");
            Console.WriteLine("5. Edit movie information");
            Console.WriteLine("6. View All Reservations");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    AdminOptions.AddMovies();
                    break;
                case "2":
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
                    ReservationInterface.DisplayAllReservations();
                    break;
                case "7":
                    exit = true;
                    Console.Clear();
                    return;
            }
        }
    }
}