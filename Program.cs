using Newtonsoft.Json;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DataAccess;
using Logic;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using DataAccess;
using Logic;

class Program
{
    public static void Main()
    {
        //MainMenu.Start();
        Console.Clear();
        List<Show> Shows = AccessData.ReadShowsJson();
        string UserInp = Console.ReadLine();
        Console.WriteLine($"Movie:{UserInp}");
        int IndexNumber = 1;

        foreach (Show show in Shows)
        {

            if (show.Moviename == UserInp)
            {
                Console.WriteLine($"[SHOW {IndexNumber}] Start at {show.MovieStartDate}                   End at {show.MovieEndDate}");
                IndexNumber++;
                HallDisplay.DisplayHall(show);
            }
        }
    }
}
