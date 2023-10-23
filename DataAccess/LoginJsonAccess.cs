using Newtonsoft.Json;

namespace DataAccess
{
    public class UserLoginUtility
    {
        public class UserData
        {
            public string? Email { get; set; }
            public string? Password { get; set; }
        }

        public static void UserLogin(string email, string password, string jsonFilePath)
        {
            List<UserData> users = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText(jsonFilePath))!;

            bool userFound = false;

            foreach (UserData user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    userFound = true;
                    break;
                }
            }

            if (userFound)
            {
                Console.WriteLine("\nLogin successful!\n");

            }
            else
            {
                Console.WriteLine("\nLogin failed. Please check your email and password.");
            }
        }
    }
}
