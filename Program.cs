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
        // MainMenu.Start();
        // Schedule.CreateShow();
        Viewer.DisplayOnlyAvailableShows();
        Show showobject = Viewer.SelectShow(3);
        Console.WriteLine(showobject.ChairsFileName);
    }
}
