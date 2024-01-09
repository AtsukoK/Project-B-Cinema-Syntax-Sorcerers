using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
class Reservation

{
    public static void View()
    {
        while (true)
        {
            Viewer.DisplayOnlyAvailableShows();
            Console.WriteLine("\nSelect show time by number: ");

            try
            {
                int userChoice = Convert.ToInt32(Console.ReadLine()!);
                Show selectedShow = Viewer.SelectShow(userChoice)!;

                if (selectedShow != null)
                {
                    Console.Clear();
                    Viewer.ViewShows(selectedShow.Moviename);
                    HallDisplay.DisplayHall(selectedShow);

                    List<Movie> movies = AccessData.ReadMoviesJson();
                    Movie selectedMovie = movies.FirstOrDefault(movie => movie.Title == selectedShow.Moviename)!;

                    ReserveChair(selectedShow, selectedMovie, userChoice);
                    break;
                }

                //if the show doesnt exist or input is invalid this will be printed
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input or show number. Please enter a valid show number.");
                Console.ResetColor();
                Thread.Sleep(2000);
            }
            catch (FormatException)
            {
                //if input is invalid this will be printed  - letter instead of number
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid show number.");
                Console.ResetColor();
                Thread.Sleep(2000);
            }
        }
    }

    public static void ReserveChair(Show show, Movie movie, int choice)
    {
        List<Chair> allChairs = show.Chairs;
        List<Chair> reservedChairs = new List<Chair>();
        List<ChairInfo> reservedChairInfos = new List<ChairInfo>();
        double totalCost = 0;

        while (true)
        {
            Console.WriteLine("\nEnter the row number OR type 'done' to finish:");
            string selectedRowInput = Console.ReadLine()!;

            if (selectedRowInput.ToLower() == "done")
            {
                Console.Clear();
                break;
            }

            if (!int.TryParse(selectedRowInput, out int selectedRow) || selectedRow <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nInvalid row number. Please enter a valid row number.");
                Console.ResetColor();
                continue;
            }

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

                if (!int.TryParse(selectedChairId, out int chairId) || chairId <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nInvalid chair number. Please enter a valid chair number.");
                    Console.ResetColor();
                    continue;
                }

                Chair selectedChair = availableChairsInRow.Find(chair => chair.ChairInTheRow == int.Parse(selectedChairId))!;

                if (selectedChair != null)
                {
                    selectedChair.IsReserved = true;
                    selectedChair.ReservedBy = ActiveUser.LoggedUser;
                    reservedChairs.Add(selectedChair);
                    reservedChairInfos.Add(new ChairInfo(selectedRow, selectedChair.ChairInTheRow));

                    if (movie != null)
                    {
                        double chairCost = Math.Round(movie.Price * selectedChair.Price, 2);
                        totalCost += chairCost;
                        HallDisplay.DisplayHall(show);
                        CheckOutObj userReservation = new CheckOutObj(ActiveUser.LoggedUser.Name, show.Moviename, show.HallType, reservedChairInfos, totalCost, show.MovieStartDate, show.MovieEndDate);
                        List<Person> userList = AccessData.ReadPersonJson();
                        var currentUser = userList.FirstOrDefault(person => person.Email == ActiveUser.LoggedUser.Email);

                        if (currentUser != null)
                        {
                            currentUser.Reservations.Add(userReservation);
                            AccessData.SyncUserWithJsonFile(currentUser);
                            // Update ActiveUser.LoggedUser
                            ActiveUser.LoggedUser = currentUser;
                        }
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
        PurchasingMenu.View();

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