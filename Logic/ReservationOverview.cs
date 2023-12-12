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
        // Console.Clear();
        Viewer.ViewShows(selectedShow.Moviename);
        HallDisplay.DisplayHall(selectedShow);

        List<Movie> movies = AccessData.ReadMoviesJson();
        Movie selectedMovie = movies.FirstOrDefault(movie => movie.Title == selectedShow.Moviename)!;

        ReserveChair(selectedShow, selectedMovie, userChoice);
    }

    public static void ReserveChair(Show show, Movie movie, int choice)
    {
        List<Chair> allChairs = show.Chairs;
        List<Chair> reservedChairs = new List<Chair>();
        double totalCost = 0;

        while (true)
        {
            Console.WriteLine("\nEnter the row number OR type 'done' to finish:");
            string selectedRowInput = Console.ReadLine()!;

            if (selectedRowInput.ToLower() == "done")
            {
                break;
            }

            int selectedRow = int.Parse(selectedRowInput);

            if (!allChairs.Any(chair => chair.Row == selectedRow))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nInvalid row number {selectedRow}. Please enter a valid row number.");
                Console.ResetColor();
                continue;
            }

            List<Chair> availableChairsInRow = allChairs
                .Where(chair => chair.Row == selectedRow && !chair.IsReserved)
                .ToList();

            if (availableChairsInRow.Count > 0)
            {
                Console.WriteLine("\nEnter the number of the chair you want to reserve OR type 'done' to finish:");
                string selectedChairId = Console.ReadLine()!;

                if (selectedChairId.ToLower() == "done")
                {
                    break;
                }

                Chair selectedChair = availableChairsInRow.Find(chair => chair.ChairInTheRow == int.Parse(selectedChairId))!;

                if (selectedChair != null)
                {
                    selectedChair.IsReserved = true;
                    reservedChairs.Add(selectedChair);

                    if (movie != null)
                    {
                        double chairCost = Math.Round(movie.Price * selectedChair.Price, 2);
                        totalCost += chairCost;
                        HallDisplay.DisplayHall(show);
                        Console.WriteLine($"\nChair {selectedChairId} in Row {selectedRow} reserved successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Error: Movie information not available.");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid chair number. Please select an available chair.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nNo available chairs in Row {selectedRow}. Please select another row.");
                Console.ResetColor();
            }
        }

        string formattedNumber = totalCost.ToString("F2");
        Console.WriteLine($"\nTotal cost: €{formattedNumber}\n");

        // Update JSON files
        string updatedJson = JsonConvert.SerializeObject(allChairs, Formatting.Indented);
        Show newShow = show;
        List<Show> shows = AccessData.ReadShowsJson();

        if (choice - 1 >= 0 && choice - 1 < shows.Count)
        {
            shows[choice - 1] = newShow;
        }
        else
        {
            Console.WriteLine("Invalid show selection.");
        }

        string jsonFilePath = Path.Combine("Datasources", show.ChairsFileName);
        File.WriteAllText(jsonFilePath, updatedJson);

        string updatedJsonFile = JsonConvert.SerializeObject(shows, Formatting.Indented);
        string jsonFile = Path.Combine("Datasources", "ShowList.json");
        File.WriteAllText(jsonFile, updatedJsonFile);
    }


}