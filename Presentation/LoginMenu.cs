public class LoginMenu
{
        public static void Main()
    {
        Console.WriteLine("Welcome to CINEMAX!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Create account");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                // Code for logging in
                Console.WriteLine("Login.");
                break;
            case "2":
                // Code for creating an account
                Console.WriteLine("You chose to create an account.");

                Console.Write("Please enter a username: ");
                string username = Console.ReadLine();

                Console.Write("Please enter a password: ");
                string password = Console.ReadLine();
                // Hide the password as it is typed
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);

                    // Ignore any non-character keys
                    if (char.IsLetterOrDigit(key.KeyChar))
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                } while (key.Key != ConsoleKey.Enter);

                Console.WriteLine();

                Console.Write("Please enter an email address: ");
                string email = Console.ReadLine();

                Console.Write("Please enter a phone number (optional): ");
                string phone = Console.ReadLine();

                bool isValid = AccountValidation.ValidateLoginData(username, password, email, phone);

                if (isValid)
                {
                    Console.WriteLine("Account created successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid account information. Please try again.");
                }

                    break;
            default:
                Console.WriteLine("Invalid choice. Please choose either 1 or 2.");
                break;
        }
    }
}
