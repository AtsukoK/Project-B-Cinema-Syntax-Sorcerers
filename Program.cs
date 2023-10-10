using Newtonsoft.Json;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;




class Program
{
    public static void Main()
    {
        Console.WriteLine("Account creation testing");
        Console.WriteLine(" ( 1/  Login)");
        Console.WriteLine(" ( 2/  Create account)\n");

        Console.WriteLine("You have chosen 1;");
        CreateUser();

        static List<Person> ReadPersonJson()
        {
            string ExistingJsonPersonData = File.Exists("Person.json") ? File.ReadAllText("Person.json") : "[]"; //replace person.json with actual file path
            List<Person> PersonList = JsonConvert.DeserializeObject<List<Person>>(ExistingJsonPersonData);
            return PersonList;
        }

        static void CreateUser()
        {
            Console.WriteLine("Create your login");
            Console.WriteLine("Email?");
            string email = Console.ReadLine();
            Console.WriteLine("Name?");
            string name = Console.ReadLine();
            Console.WriteLine("Password?");
            string password = Console.ReadLine();
            Person person = new Person(
                email, name, password, false, reservations: new List<CheckOutObj>()
            );
            List<Person> PersonList = ReadPersonJson(); //READ AND CREATE LIST OF ALL JSON DATA OF PERSONS
            PersonList.Add(person);

            Console.WriteLine(PersonList);

            string updatedJson = JsonConvert.SerializeObject(PersonList, Formatting.Indented);

            File.WriteAllText("Person.json", updatedJson);
        }



    }
}