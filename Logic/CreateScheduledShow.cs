using System.Xml.Serialization;
using System;
using System.Runtime.InteropServices.Marshalling;
using System.Diagnostics;
using System.ComponentModel.Design;
using DataAccess;

class Schedule
{
    public static void ScheduleAMovie()
    {
        DateTime dateTime;
        Console.Clear();
        Console.WriteLine("Scheduling movie for a specific date.\n");
        Console.Write("Please Enter a date in format dd/mm/yyyy: ");
        String schedulestring = Console.ReadLine();
        var isValidDate = DateTime.TryParse(schedulestring, out dateTime);
        if (isValidDate)
        {
            dateTime = DateTime.ParseExact(schedulestring, "dd/M/yyyy", null);
            Console.WriteLine($"Your selected date is: {dateTime.ToShortDateString()}");
            Console.WriteLine("Is this correct?\n1) Yes.  \n2) No.");
            String ans = Console.ReadLine();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid date, please try again.");
            Console.ResetColor();
            Thread.Sleep(3000);
            ScheduleAMovie();
        }
    }

    public static void SelectMovie()
    {
        Console.Write("Enter Movie Title: ");
        String selection = Console.ReadLine();
        List<string> listMoviesString = new();
        List<Movie> Movielist = AccessData.ReadMoviesJson();
        foreach (Movie movie in Movielist)
        {
            listMoviesString.Add(movie.Title);
        }
        if (selection in listMoviesString)
        {
            Console.WriteLine($"Movie: {selection} selected.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong movie input, please try again.");
            Thread.Sleep(3000);
            Console.ResetColor();
            SelectMovie();
        }

    }
}