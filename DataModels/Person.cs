using System.ComponentModel.DataAnnotations;
using DataAccess;

public class Person : UserLoginUtility.UserData
{
    public string Name { get; set; }
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