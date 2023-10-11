using System.Text.Json;

namespace DataAccess
{
    public class UserLoginUtility
    {
        public static void UserLogin()
        {
            string dataFolderPath = "DataSources";
            string fileName = Path.Combine(dataFolderPath, "Person.json");

            if (!File.Exists(fileName))
            {
                Console.WriteLine("User data file does not exist.");
                return;
            }

            Console.Write("Enter your Email: ");
            string email = Console.ReadLine()!;
            Console.Write("Enter your Password: ");
            string password = Console.ReadLine()!;

            string jsonText = File.ReadAllText(fileName);

            var userData = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonText);

            if (userData == null)
            {
                Console.WriteLine("Error parsing JSON data.");
                return;
            }

            foreach (var user in userData)
            {
                if (user.TryGetValue("Email", out object? userEmail) && user.TryGetValue("Password", out object? userPassword) &&
                    userEmail is string emailStr && userPassword is string passwordStr &&
                    emailStr == email && passwordStr == password)
                {
                    Console.WriteLine("Login successful!");
                    return;
                }
            }

            Console.WriteLine("\nLogin failed. Email or password is incorrect.");
        }
    }
}
