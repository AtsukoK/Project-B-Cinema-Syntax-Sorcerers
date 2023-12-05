using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Reservation

{
    public static void View()
    {
        Viewer.DisplayOnlyAvailableShows();
        Console.WriteLine("Select show time by number: ");
        int userChoice = Convert.ToInt32(Console.ReadLine()!);
        Show selectedShow = Viewer.SelectShow(userChoice);
        Console.Clear();
        HallDisplay.DisplayHall(selectedShow);
        Console.WriteLine("Enter the number of the chair you want to reserve:");

        string selectedChairId = Console.ReadLine()!;
        List<Movie> movies = AccessData.ReadMoviesJson();
        Movie selectedMovie = null;

        foreach (Movie movie in movies)
        {
            if (movie.Title == selectedShow.Moviename)
            {
                selectedMovie = movie;
            }
        }

        ReserveChair(selectedShow, selectedChairId, selectedMovie!, userChoice);

    }

    public static bool ReserveChair(Show show, string chairId, Movie movie, int choice)
    {
        List<Chair> allChairs = show.Chairs;

        if (allChairs != null)
        {
            Chair selectedChair = allChairs.Find(chair => chair.ID == int.Parse(chairId))!;

            if (selectedChair != null && !selectedChair.IsReserved)
            {
                selectedChair.IsReserved = true;
                Console.WriteLine($"\nChair {selectedChair.ID} reserved successfully!\n");

                if (movie != null)
                {
                    HallDisplay.DisplayHall(show);
                    double totalCost = movie.Price * selectedChair.Price;
                    string formattedNumber = totalCost.ToString("F2");
                    Console.WriteLine($"\nTotal Cost: ${formattedNumber}\n");


                    string updatedJson = JsonConvert.SerializeObject(allChairs, Formatting.Indented);
                    Show newShow = show;
                    List<Show> shows = AccessData.ReadShowsJson();

                    //subtracts 1 from the choice variable before using it as an index
                    // because the first index is 0 and not 1

                    if (choice - 1 >= 0 && choice - 1 < shows.Count)
                    {
                        shows[choice - 1] = newShow;
                    }
                    else
                    {
                        Console.WriteLine("Invalid show selection.");
                    }


                    string jsonFilePath = Path.Combine("Datasources", show.ChairsFileName); // Datasource/filename
                    File.WriteAllText(jsonFilePath, updatedJson);


                    string updatedJsonFile = JsonConvert.SerializeObject(shows, Formatting.Indented);
                    string jsonFile = Path.Combine("Datasources", "ShowList.json"); // Datasource/ShowList.json
                    File.WriteAllText(jsonFile, updatedJsonFile);
                    // AccessData.ReadShowsJson();
                }

                else
                {
                    Console.WriteLine("Error: Movie information not available.");
                }

                return true;
            }
        }
        Console.WriteLine("Chair not found or already reserved.");
        return false;
    }
}