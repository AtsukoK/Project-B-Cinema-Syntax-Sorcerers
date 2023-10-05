using System.ComponentModel.DataAnnotations;

public class Person
{
    public string Email;
    public string Name;
    public string Password;
    public bool IsAdmin;
    public List<CheckOutObj> Reservations;

    public Person(string email, string name, string password, bool isadmin, List<CheckOutObj> reservations)
    {
        Email = email;
        Name = name;
        Password = password;
        IsAdmin = isadmin;
        Reservations = reservations;
    }


}