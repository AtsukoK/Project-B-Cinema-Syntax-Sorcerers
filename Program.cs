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
        List<Chair> Chairs = SmallHallCreation.GenerateSmallHall();
        int currentROW = 1;
        int currentChairIndex = 0;

        while (currentChairIndex < Chairs.Count)
        {
            if (Chairs[currentChairIndex].Row == currentROW)
            {
                Chair chair = Chairs[currentChairIndex];

                if (chair.ID == 0)
                {
                    Console.Write("[---]");
                }
                else if (chair.ID < 10)
                {
                    Console.Write($"[00{chair.ID}]");
                }
                else if (chair.ID < 100)
                {
                    Console.Write($"[0{chair.ID}]");
                }
                else
                {
                    Console.Write($"[{chair.ID}]");
                }

                currentChairIndex++;
            }
            else
            {
                Console.WriteLine();
                currentROW++;
            }
        }
        Console.WriteLine("\n");
        Console.WriteLine("Which filename?");
        String newfilename = Console.ReadLine();

        string updatedJson = JsonConvert.SerializeObject(Chairs, Formatting.Indented);
        string jsonFilePath = Path.Combine("Datasources", newfilename); // Datasource/filename
        File.WriteAllText(jsonFilePath, updatedJson);
    }
}
