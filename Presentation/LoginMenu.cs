
// public class LoginMenu
// {
//         public static void Main()
//     {
//         Console.WriteLine("Welcome to CINEMAX!");
//         Console.WriteLine("Please choose an option:");
//         Console.WriteLine("1. Login");
//         Console.WriteLine("2. Create account");

//         string choice = Console.ReadLine();

//         switch (choice)
//         {
//             case "1":
//                 // Code for logging in
//                 Console.WriteLine("Login.");
//                 break;
//             case "2":
//                 // Code for creating an account
//                 Console.WriteLine("You chose to create an account.");

//                 Console.Write("Please enter a username: ");
//                 string username = Console.ReadLine();

//                 Console.Write("Please enter a password: ");
//                 string password = Console.ReadLine();
//                 // Hide the password as it is typed
//                 ConsoleKeyInfo key;
//                 do
//                 {
//                     key = Console.ReadKey(true);

//                     // Ignore any non-character keys
//                     if (char.IsLetterOrDigit(key.KeyChar))
//                     {
//                         password += key.KeyChar;
//                         Console.Write("*");
//                     }
//                 } while (key.Key != ConsoleKey.Enter);

//                 Console.WriteLine();

//                 Console.Write("Please enter an email address: ");
//                 string email = Console.ReadLine();

//                 Console.Write("Please enter a phone number (optional): ");
//                 string phone = Console.ReadLine();

//                 bool isValid = AccountValidation.ValidateLoginData(username, password, email, phone);

//                 // while (!isValid)
//                 // {
//                 //     Console.WriteLine("Invalid account information. Please try again.");

//                 //     if (!AccountValidation.ValidateUsername(username))
//                 //     {
//                 //         Console.Write("Please enter a different username: ");
//                 //         username = Console.ReadLine();
//                 //     }

//                 //     if (!AccountValidation.ValidatePassword(password))
//                 //     {
//                 //         Console.Write("Please enter a different password: ");
//                 //         password = Console.ReadLine();
//                 //     }

//                 //     if (!AccountValidation.ValidateEmail(email))
//                 //     {
//                 //         Console.Write("Please enter a different email address: ");
//                 //         email = Console.ReadLine();
//                 //     }

//                 //     if (!AccountValidation.ValidatePhone(phone))
//                 //     {
//                 //         Console.Write("Please enter a different phone number (optional): ");
//                 //         phone = Console.ReadLine();
//                 //     }
//                 //}



//                 if (isValid)
//                 {
//                     Console.WriteLine("Account created successfully!");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid account information. Please try again.");
//                 }

//                     break;
//             default:
//                 Console.WriteLine("Invalid choice. Please choose either 1 or 2.");
//                 break;
//         }
//     }
// }
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

            Console.WriteLine(PersonList);

            string updatedJson = JsonConvert.SerializeObject(PersonList, Formatting.Indented);
            string jsonFilePath = Path.Combine("Datasources", "Person.json"); // Datasource/Person.json
            File.WriteAllText(jsonFilePath, updatedJson);
            Console.WriteLine("Account created successfully!");

        }
    }
}
