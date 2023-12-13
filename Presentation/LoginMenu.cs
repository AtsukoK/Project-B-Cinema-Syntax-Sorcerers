using DataAccess;
using Logic;
public class Menu
{
    public static void LoginMenu()
    {
        bool exit = false;

        while (!exit)
        {
            // Inlog systeem
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
            Console.WriteLine("\nLogin or Create an account?\n");
            Console.WriteLine("1. Login\n2. Create account\n3. Exit");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    // If user chooses to login
                    string dataFolderPath = "DataSources";
                    string jsonFilePath = Path.Combine(dataFolderPath, "Person.json");

                    bool loginSuccess = false;

                    do
                    {
                        Console.Clear();
                        Console.Write("Enter your email: ");
                        string userEmail = Console.ReadLine()!;

                        string userPassword = MaskPassword();
                        UserLoginUtility.UserData loggedInUser = UserLoginUtility.UserLogin(userEmail, userPassword, jsonFilePath);

                        if (loggedInUser != null)
                        {
                            if (loggedInUser.IsAdmin)
                            {
                                // Admin-specific actions
                                AdminMenuDisplay.View();
                            }
                            else
                            {
                                // Regular user-specific actions
                                Console.Clear();
                                loginSuccess = true;
                                MainMenu.Start();
                                exit = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Login failed. Invalid email or password. Please try again.");
                            Console.WriteLine("Press ENTER to try again or type 'exit' to go back to the main menu.");

                            string userInput = Console.ReadLine()!;
                            if (userInput?.ToLower() == "exit")
                            {
                                exit = true;
                                break; // Exit the loop and go back to the main menu
                            }
                        }
                    } while (!loginSuccess);

                    break;
                case "2":
                    // call method "Create account"
                    UserCreation.CreateUser();
                    exit = true;

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


