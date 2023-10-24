using DataAccess;
using Newtonsoft.Json;
namespace Logic
{
    public class UserCreation
    {
        public static void CreateUser()
        {

            Console.WriteLine("Create your login");
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            while (!AccountValidation.ValidateEmail(email))
            {
                Console.Write("Email invalid or taken: ");
                email = Console.ReadLine();
            }

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            while (!AccountValidation.ValidateName(name))
            {
                Console.Write("Name invalid or taken: ");
                name = Console.ReadLine();
            }
            Console.Write("Password: ");
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                // Backspace should not work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            string passwordValidationResult = AccountValidation.ValidatePassword(password);
            while (!string.IsNullOrEmpty(passwordValidationResult))
            {
                Console.WriteLine(passwordValidationResult);
                Console.Write("Password: ");
                password = "";
                do
                {
                    key = Console.ReadKey(true);

                    // Backspace should not work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                    else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Remove(password.Length - 1);
                        Console.Write("\b \b");
                    }
                } while (key.Key != ConsoleKey.Enter);

                passwordValidationResult = AccountValidation.ValidatePassword(password);
            }

            Console.WriteLine("Phone number (optional): ");
            string phone = Console.ReadLine();
            while (!AccountValidation.ValidatePhone(phone))
            {
                Console.Write("Invalid phone number (optional): ");
                phone = Console.ReadLine();
            }

            Person person = new Person(
            email, name, password, false, reservations: new List<CheckOutObj>()
            );
            List<Person> PersonList = AccessData.ReadPersonJson(); //READ AND CREATE LIST OF ALL JSON DATA OF PERSONS
            PersonList.Add(person);
            string updatedJson = JsonConvert.SerializeObject(PersonList, Formatting.Indented);
            string jsonFilePath = Path.Combine("Datasources", "Person.json"); // Datasource/Person.json
            File.WriteAllText(jsonFilePath, updatedJson);
            Console.WriteLine("Account created successfully!");

        }
    }
}