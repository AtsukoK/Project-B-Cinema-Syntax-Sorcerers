using System.Xml.Serialization;
using System;
using System.Runtime.InteropServices.Marshalling;
using System.Diagnostics;
using System.ComponentModel.Design;
using DataAccess;

class Schedule
{
    public static DateTime Schedule1MovieDate()
    {
        do
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
                if (ans == "1")
                {
                    return dateTime;
                }
                else
                {
                    Schedule1MovieDate();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid date, please try again.");
                Console.ResetColor();
                Thread.Sleep(3000);
            }

        } while (true);

    }

    public static String Schedule2MovieName()
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
                Schedule2MovieName();
            }
        } while (true);
    }

    public static String Schedule3SelectMovieTime()
    {
        // TimeSpan StartTime;
        // TimeSpan EndTime;

        //do
        {
            Console.Clear();
            Console.WriteLine("What time does the movie start? enter in format 0-24H (HH:mm): ");
            String StartTimeInput = Console.ReadLine();
            Console.WriteLine("What time does the movie end? enter in format 0-24H (HH:mm):  ");
            String EndTimeInput = Console.ReadLine();
            return $"{StartTimeInput} - {EndTimeInput}";

        }
        //while (true);
    }


}