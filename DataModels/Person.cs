using System.ComponentModel.DataAnnotations;

public class Person
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
    public List<CheckOutObj> Reservations { get; set; }

    public Person(string email, string name, string password, bool isadmin, List<CheckOutObj> reservations)
    {
        Email = email;
        Name = name;
        Password = password;
        IsAdmin = isadmin;
        Reservations = reservations;
    }


}