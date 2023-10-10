using DataAccess;
using Newtonsoft.Json;
namespace Logic
{
    public class UserCreation
    {
        public static void CreateUser()
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
            List<Person> PersonList = AccessPersonData.ReadPersonJson(); //READ AND CREATE LIST OF ALL JSON DATA OF PERSONS
            PersonList.Add(person);

            Console.WriteLine(PersonList);

            string updatedJson = JsonConvert.SerializeObject(PersonList, Formatting.Indented);
            string jsonFilePath = Path.Combine("Datasources", "Person.json"); // Datasource/Person.json
            File.WriteAllText(jsonFilePath, updatedJson);
        }
    }
}