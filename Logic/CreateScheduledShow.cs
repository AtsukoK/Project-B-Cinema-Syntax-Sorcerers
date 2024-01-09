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
    public static String ScheduleMovieName()
    {
        do
        {
            List<Movie> movies = AccessData.ReadMoviesJson();
            foreach (Movie mov in movies)
            {
                Console.WriteLine(mov.Title);
            }
            Console.Write("\nEnter Movie Title: ");
            String selection = Console.ReadLine();
            List<string> listMoviesString = new();
            List<Movie> Movielist = AccessData.ReadMoviesJson();
            foreach (Movie movie in Movielist)
            {
                listMoviesString.Add(movie.Title);
            }
            if (listMoviesString.Contains(selection))
            {
                Console.WriteLine($"Movie: {selection} selected.\n");
                return selection;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong movie input, please try again.");
                Thread.Sleep(1000);
                Console.ResetColor();
            }
        } while (true);
    }

    public static DateTime GetDateTime()
    {
        Console.WriteLine("Enter the start date and time for the movie:");

        // Get the date
        Console.Write("Enter the date (dd/MM/yyyy): ");
        DateTime DateObject = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine();

        // Get the time
        Console.Write("Enter the time (HH:mm): ");
        DateTime TimeObject = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
        Console.WriteLine();

        // Combine date and time to get the starting date and time for the movie
        DateTime DateTimeObject = DateObject.Add(TimeObject.TimeOfDay);

        return DateTimeObject;
    }

    public static void CreateShow()
    {
        //Get Movie Name first
        Console.Clear();
        Console.WriteLine("Enter movie name for which you want to create a scheduled show:\n");
        string MovieName = ScheduleMovieName();

        DateTime StartDate = GetDateTime();

        DateTime EndDate = GetDateTime();

        string filenameDateTimeString = StartDate.ToString("yyyyMMdd_HHmmss");
        string finalName = $"{MovieName}-{filenameDateTimeString}";

        // Display the filename-friendly date-time string
        // Console.WriteLine($"Filename-Friendly Date-Time String: {filenameDateTimeString}");

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
            NewFinalName = $"{finalName}-hall1.json";
            generatedchairs = HallCreation.GenerateOverview(rowsofchairs, NewFinalName);
            newShow = new Show(generatedchairs, MovieName, NewFinalName, StartDate, EndDate, 1);
            ShowList.Add(newShow);


        }
        else if (choice == "2")
        {
            Console.WriteLine("You selected hall 2.");
            rowsofchairs = HallCreation.GenerateMediumHall();
            NewFinalName = $"{finalName}-hall2.json";
            generatedchairs = HallCreation.GenerateOverview(rowsofchairs, NewFinalName);
            newShow = new Show(generatedchairs, MovieName, NewFinalName, StartDate, EndDate, 2);
            ShowList.Add(newShow);
        }
        else if (choice == "3")
        {
            Console.WriteLine("You selected hall 3.");
            rowsofchairs = HallCreation.GenerateLargeHall();
            NewFinalName = $"{finalName}-hall3.json";
            generatedchairs = HallCreation.GenerateOverview(rowsofchairs, NewFinalName);
            newShow = new Show(generatedchairs, MovieName, NewFinalName, StartDate, EndDate, 3);
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