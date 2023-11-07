using Newtonsoft.Json;

namespace DataAccess
{
    public class UserLoginUtility
    {
        public class UserData
        {
            public string? Email { get; set; }
            public string? Password { get; set; }
            public bool IsAdmin { get; set; }
        }

        public static bool UserLogin(string email, string password, string jsonFilePath)
        {
            List<UserData> users = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText(jsonFilePath))!;

            bool userFound = false;
            bool isAdmin = false;

            foreach (UserData user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    userFound = true;
                    isAdmin = user.IsAdmin;
                    break;
                }
            }

            if (userFound)
            {
                if (isAdmin)
                {
                    Console.WriteLine("\nAdmin login successful!\n");
                }
                else
                {
                    Console.WriteLine("\nUser login successful!\n");
                }
                // geen console writelines in deze laag
            }
            else
            {
                Console.WriteLine("\nLogin failed. Please check your email and password.");
            }
            return isAdmin;
        }
    }
}
