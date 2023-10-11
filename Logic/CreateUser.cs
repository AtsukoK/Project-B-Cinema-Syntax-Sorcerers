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
            Console.WriteLine("Password: ");
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
            while (!AccountValidation.ValidatePassword(password))
            {
                Console.Write("Password invalid: ");
                password = Console.ReadLine();
            }

            // Console.WriteLine("Phone number (optional): ");
            // string phone = Console.ReadLine();
            // while (!AccountValidation.ValidatePhone(phone))
            // {
            //     Console.Write("Invalid phone number (optional): ");
            //     phone = Console.ReadLine();
            // }

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