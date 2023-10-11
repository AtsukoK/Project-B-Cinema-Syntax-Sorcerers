using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;
using DataAccess;

public static class AccountValidation
{
    public static bool ValidateName(string name)
    {
        // Validate user
        if (string.IsNullOrEmpty(name))
        {
            return false;
        }

        // Check if username is unique
        string jsonFilePath = Path.Combine("Datasources", "Person.json");
        var json = File.ReadAllText(jsonFilePath);
        var persons = JsonSerializer.Deserialize<List<Person>>(json);
        if (persons.Any(p => p.Name == name))
        {
            return false;
        }

        return true;
    }
    public static bool ValidatePassword(string password)
    {
        // Validate password
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return false;
        }

        if (!password.Any(char.IsUpper) || !password.Any(char.IsLower) || !password.Any(char.IsDigit) || !password.Any(char.IsSymbol))
        {
            return false;
        }

        return true;
    }
    public static bool ValidateEmail(string email)
    // Validate email
    {
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }
        // Check if email is unique
        string jsonFilePath = Path.Combine("Datasources", "Person.json");
        var jsonString = File.ReadAllText(jsonFilePath);
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
        else
        {
            return true;
        }
    }

    public static bool ValidatePhone(string phoneNumber)
    {
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

