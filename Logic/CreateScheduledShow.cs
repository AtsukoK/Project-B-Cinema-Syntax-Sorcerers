using System.Xml.Serialization;
using System;
using System.Runtime.InteropServices.Marshalling;
using System.Diagnostics;
using System.ComponentModel.Design;
using DataAccess;
using System.Data;
using Newtonsoft.Json;

class Schedule
{

    // public static DateTime Schedule1MovieDate()
    // {
    //     do
    //     {
    //         DateTime dateTime;
    //         Console.Clear();
    //         Console.WriteLine("Scheduling movie for a specific date.\n");
    //         Console.Write("Please Enter a date in format dd/mm/yyyy: ");
    //         String schedulestring = Console.ReadLine();
    //         var isValidDate = DateTime.TryParse(schedulestring, out dateTime);
    //         if (isValidDate)
    //         {
    //             dateTime = DateTime.ParseExact(schedulestring, "dd/M/yyyy", null);
    //             Console.WriteLine($"Your selected date is: {dateTime.ToShortDateString()}");
    //             Console.WriteLine("Is this correct?\n1) Yes.  \n2) No.");
    //             String ans = Console.ReadLine();
    //             if (ans == "1")
    //             {
    //                 return dateTime;
    //             }
    //             else
    //             {
    //                 Schedule1MovieDate();
    //             }
    //         }
    //         else
    //         {
    //             Console.ForegroundColor = ConsoleColor.Red;
    //             Console.WriteLine("Invalid date, please try again.");
    //             Console.ResetColor();
    //             Thread.Sleep(3000);
    //         }

    //     } while (true);

    // }

    public static String ScheduleMovieName()
    {
        do
        {
            Console.Write("Enter Movie Title: ");
            String selection = Console.ReadLine();
            List<string> listMoviesString = new();
            List<Movie> Movielist = AccessData.ReadMoviesJson();
            foreach (Movie movie in Movielist)
            {
                listMoviesString.Add(movie.Title);
            }
            if (listMoviesString.Contains(selection))
            {
                Console.WriteLine($"Movie: {selection} selected.");
                return selection;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong movie input, please try again.");
                Thread.Sleep(3000);
                Console.ResetColor();
                ScheduleMovieName();
            }
        } while (true);
    }

    public static DateTime GetDateTime()
    {
        Console.WriteLine("Enter the date and time for the movie:");

        // Get the date
        Console.Write("Enter the date (dd/MM/yyyy): ");
        DateTime DateObject = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        // Get the time
        Console.Write("Enter the time (HH:mm): ");
        DateTime TimeObject = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);

        // Combine date and time to get the starting date and time for the movie
        DateTime DateTimeObject = DateObject.Add(TimeObject.TimeOfDay);

        return DateTimeObject;
    }

    public static void CreateShow()
    {
        //Get Movie Name first
        Console.WriteLine("Enter movie name for which you want to create a scheduled show:");
        string MovieName = ScheduleMovieName();

        Console.WriteLine("Now enter a starting date for the show:");
        DateTime StartDate = GetDateTime();

        Console.WriteLine("Now enter a starting date for the show:");
        DateTime EndDate = GetDateTime();

        string filenameDateTimeString = StartDate.ToString("yyyyMMdd_HHmmss");
        string finalName = $"{MovieName}-{filenameDateTimeString}";

        // Display the filename-friendly date-time string
        Console.WriteLine($"Filename-Friendly Date-Time String: {filenameDateTimeString}");

        Console.WriteLine("Now choose a hall for the show:");
        Console.WriteLine("Hall 1 - 150 seats");
        Console.WriteLine("Hall 2 - 300 seats");
        Console.WriteLine("Hall 3 - 500 seats\n");

        Console.Write("Please Input the number of the hall you wish to select: ");
        string choice = Console.ReadLine();
        string NewFinalName;
        List<Chair> generatedchairs = new List<Chair> { };

        List<List<char>> rowsofchairs = new List<List<char>> { };

        Show newShow = null;

        List<Show> ShowList = AccessData.ReadShowsJson();

        if (choice == "1")
        {
            Console.WriteLine("You selected hall 1.");
            rowsofchairs = HallCreation.GenerateSmallHall();
            NewFinalName = $"{finalName}-hall1";
            generatedchairs = HallCreation.GenerateOverview(rowsofchairs, NewFinalName);
            newShow = new Show(generatedchairs, MovieName, NewFinalName, StartDate, EndDate);
            ShowList.Add(newShow);


        }
        else if (choice == "2")
        {
            Console.WriteLine("You selected hall 2.");
            rowsofchairs = HallCreation.GenerateMediumHall();
            NewFinalName = $"{finalName}-hall2";
            generatedchairs = HallCreation.GenerateOverview(rowsofchairs, NewFinalName);
            newShow = new Show(generatedchairs, MovieName, NewFinalName, StartDate, EndDate);
            ShowList.Add(newShow);
        }
        else if (choice == "3")
        {
            Console.WriteLine("You selected hall 3.");
            rowsofchairs = HallCreation.GenerateLargeHall();
            NewFinalName = $"{finalName}-hall3";
            generatedchairs = HallCreation.GenerateOverview(rowsofchairs, NewFinalName);
            newShow = new Show(generatedchairs, MovieName, NewFinalName, StartDate, EndDate);
            ShowList.Add(newShow);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }

        string updatedJson = JsonConvert.SerializeObject(ShowList, Formatting.Indented);
        string jsonFilePath = Path.Combine("Datasources", "ShowList.json"); // Datasource/ShowList.json
        File.WriteAllText(jsonFilePath, updatedJson);
        Console.WriteLine("Show Created Successfully and saved to ShowList.Json");
    }
}