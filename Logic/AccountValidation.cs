using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;
using DataAccess;


public static class AccountValidation
{
    public static bool ValidateEmail(string email)
    // Validate email
    {
        if (string.IsNullOrEmpty(email))
        {
            return false;
        }
        // Check if email is unique
        var existingPersons = AccessData.ReadPersonJson();
        if (existingPersons != null && existingPersons.Any(p => p.Email == email))
        {
            return false;
        }
        // Checks email format using regex
        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        if (!emailRegex.IsMatch(email))
        {
            return false;
        }

        return true;
    }

    public static bool ValidateName(string name)
    {
        // Validate user
        if (string.IsNullOrEmpty(name))
        {
            return false;
        }

        // Use the AccessData class to read the Person data from JSON
        var persons = AccessData.ReadPersonJson();
        if (persons.Any(p => p.Name == name))
        {
            return false;
        }

        return true;
    }
    // public static bool ValidatePassword(string password)
    // {
    //     // Validate password
    //     if (string.IsNullOrEmpty(password) || password.Length < 8)
    //     {
    //         Console.WriteLine("Password must be at least 8 characters long.");
    //         return false;
    //     }

    //     if (!password.Any(char.IsUpper))
    //     {
    //         Console.WriteLine("Password must contain at least one uppercase letter.");
    //         return false;
    //     }

    //     if (!password.Any(char.IsLower))
    //     {
    //         Console.WriteLine("Password must contain at least one lowercase letter.");
    //         return false;
    //     }

    //     if (!password.Any(char.IsDigit))
    //     {
    //         Console.WriteLine("Password must contain at least one digit.");
    //         return false;
    //     }

    //     if (!password.Any(char.IsSymbol))
    //     {
    //         Console.WriteLine("Password must contain at least one special character.");
    //         return false;
    //     }

    //     return true;
    // }
    public static string ValidatePassword(string password)
    {
        // Validate password
        if (string.IsNullOrEmpty(password) || password.Length < 8)
        {
            return "Password must be at least 8 characters long.";
        }

        if (!password.Any(char.IsUpper))
        {
            return "Password must contain at least one uppercase letter.";
        }

        if (!password.Any(char.IsLower))
        {
            return "Password must contain at least one lowercase letter.";
        }

        if (!password.Any(char.IsDigit))
        {
            return "Password must contain at least one digit.";
        }

        if (!password.Any(c => !char.IsLetterOrDigit(c)))
        {
            return "Password must contain at least one special character.";
        }

        return null; // Password is valid
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


