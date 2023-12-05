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

        public static UserData UserLogin(string email, string password, string jsonFilePath)
        {
            List<UserData> users = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText(jsonFilePath))!;

            foreach (UserData user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user; // Return the user information
                }
            }

            return null; // Return null if no matching user is found
        }
    }
}
