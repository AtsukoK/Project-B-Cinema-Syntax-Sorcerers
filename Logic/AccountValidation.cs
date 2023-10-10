using System.Text.Json;
using System.Text.RegularExpressions;

public static class AccountValidation
{
    public static bool ValidateLoginData(string username, string password, string email, string phoneNumber = null)
    {
        // Validate username
        if (string.IsNullOrEmpty(username))
        {
            return false;
        }

        // Check if username is unique
        var json = File.ReadAllText("Person.json");
        var persons = JsonSerializer.Deserialize<List<Person>>(json);
        if (persons.Any(p => p.Name == username))
        {
            return false;
        }

        // Validate password
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }

        if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(char.IsSymbol))
        {
            return false;
        }

        // Validate email
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }

        // Check if email is unique
        var jsonString = File.ReadAllText("Person.json");
        var existingPersons = JsonSerializer.Deserialize<List<Person>>(jsonString);
        if (existingPersons.Any(p => p.Email == email))
        {
            return false;
        }
        // Checks email format using regex
        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        if (!emailRegex.IsMatch(email))
        {
            return false;
        }

        // Validate phone number (optional)
        if (!string.IsNullOrEmpty(phoneNumber))
        {
            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                return false;
            }
        }

        return true;
    }
}
