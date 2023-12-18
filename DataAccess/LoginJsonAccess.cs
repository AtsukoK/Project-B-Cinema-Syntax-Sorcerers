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

        public static Person UserLogin(string email, string password, string jsonFilePath)
        {
            List<Person> users = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(jsonFilePath))!;

            foreach (Person user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }
    }
}
