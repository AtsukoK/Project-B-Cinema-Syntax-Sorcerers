class AdminMenu
{
    public static void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to the Administrator Menu");
            Console.WriteLine("Choose out of the following options:");
            Console.WriteLine("1. Edit movies");
            Console.WriteLine("2. Delete movies");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    exit = true;
                    break;
            }
        }
    }
}