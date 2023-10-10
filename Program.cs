using Newtonsoft.Json;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DataAccess;
using Logic;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Account creation testing");
        Console.WriteLine(" ( 1/  Login)");
        Console.WriteLine(" ( 2/  Create account)\n");

        Console.WriteLine("You have chosen 1;");
        UserCreation.CreateUser();
    }
}