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
            Console.WriteLine("2. Delete movies");
            Console.WriteLine("3. Edit ticket prices");
            Console.WriteLine("4. Edit movie information");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    AdminOptions.AddMovies();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    exit = true;
                    break;
            }
        }
    }
}