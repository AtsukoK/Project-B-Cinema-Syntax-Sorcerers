using DataAccess;
public class Menu
{
    public static void LoginMenu()
    {
        bool exit = false;
        // bool isAdmin = false;
        // string adminPassword = "1234";

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
            // Inlog systeem
            Console.WriteLine("Login or Create an account?\n");
            Console.WriteLine("1. Login\n2.Create account\n3.Exit");
            // Console.WriteLine("Choose out of the following options:\n");
            // Console.WriteLine("1. View available movies");
            // Console.WriteLine("2. Purchase ticket");
            // Console.WriteLine("3. Administrator mode");
            // Console.WriteLine("4. Exit\n");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    // If user chooses to login
                    string dataFolderPath = "DataSources";
                    string jsonFilePath = Path.Combine(dataFolderPath, "Person.json");

                    Console.Write("Enter your email: ");
                    string userEmail = Console.ReadLine()!;

                    string userPassword = MaskPassword();
                    UserLoginUtility.UserLogin(userEmail, userPassword, jsonFilePath);
                    break;
                case "2":
                    // call method "Create account"

                    break;
                case "3":
                    exit = true; // Exit the menu
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter 1, 2, or 3.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    private static string MaskPassword()
    {
        Console.Write("Enter your password: ");
        string password = "";
        ConsoleKeyInfo key;
        while (true)
        {
            key = Console.ReadKey(intercept: true);

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                break;
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
            else
            {
                password += key.KeyChar;
                Console.Write("*");
            }
        }
        return password;
    }
}


