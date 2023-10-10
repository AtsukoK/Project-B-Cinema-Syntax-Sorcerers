using Newtonsoft.Json;

class AccessPersonData
{
    static List<Person> ReadPersonJson()
    {
        string jsonFilePath = Path.Combine("Datasources", "Person.json"); // Datasource/Person.json
        string ExistingJsonPersonData = File.Exists(jsonFilePath) ? File.ReadAllText(jsonFilePath) : "[]"; //replace person.json with actual file path
        List<Person> PersonList = JsonConvert.DeserializeObject<List<Person>>(ExistingJsonPersonData);
        return PersonList;
    }
}
