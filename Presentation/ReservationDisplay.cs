using DataAccess;
using Logic;

class ReservationInterface
{

public static void DisplayUserReservations(Person loggedUser)
    {
        Person refreshedUser = AccessData.GetUserByEmail(loggedUser.Email);
        if (refreshedUser != null)
        {
            loggedUser = refreshedUser;
        }

        if (loggedUser.Reservations.Any())
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tCINEMAX RESERVATION DETAILS");
            Console.WriteLine(new string('-', 50));

            foreach (var reservation in loggedUser.Reservations)
            {
                if (reservation == null || reservation.ChairInfoList == null || string.IsNullOrEmpty(reservation.MovieName))
                {
                    Console.WriteLine("Invalid reservation data.");
                    continue;
                }
                Console.WriteLine($"Show: {reservation.MovieName}");
                Console.WriteLine($"Hall: {reservation.Hall}");
                Console.WriteLine($"Date: {reservation.MovieStartDate:dddd, MMMM dd, yyyy}");
                Console.WriteLine($"Time: {reservation.MovieStartDate:HH:mm} - {reservation.MovieEndDate:HH:mm}");
                Console.WriteLine($"Customer: {loggedUser.Name}");
                Console.WriteLine($"Seats: {string.Join(", ", reservation.ChairInfoList.Select(chairInfo => $"Row {chairInfo.Row}, Seat {chairInfo.ChairInTheRow}"))}");
                Console.WriteLine($"Total Cost: EUR {reservation.totalCost:F2}");
                Console.WriteLine(new string('-', 50));
            }
        }
        else
        {
            Console.WriteLine("You have no reservations.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }

 public static void DisplayAllReservations()
    {
        List<Person> allUsers = AccessData.ReadPersonJson();

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("\tALL CINEMAX RESERVATION DETAILS");
        Console.WriteLine(new string('-', 50));

        foreach (var user in allUsers)
        {
            foreach (var reservation in user.Reservations)
            {
                if (reservation == null || reservation.ChairInfoList == null || string.IsNullOrEmpty(reservation.MovieName))
                {
                    Console.WriteLine("Invalid reservation data.");
                    continue;
                }
                Console.WriteLine($"Show: {reservation.MovieName}");
                Console.WriteLine($"Hall: {reservation.Hall}");
                Console.WriteLine($"Date: {reservation.MovieStartDate:dddd, MMMM dd, yyyy}");
                Console.WriteLine($"Time: {reservation.MovieStartDate:HH:mm} - {reservation.MovieEndDate:HH:mm}");
                Console.WriteLine($"Customer: {user.Name}");
                Console.WriteLine($"Seats: {string.Join(", ", reservation.ChairInfoList.Select(chairInfo => $"Row {chairInfo.Row}, Seat {chairInfo.ChairInTheRow}"))}");
                Console.WriteLine($"Total Cost: EUR {reservation.totalCost:F2}");
                Console.WriteLine(new string('-', 50));
            }
        }

        if (!allUsers.Any(u => u.Reservations.Any()))
        {
            Console.WriteLine("There are no reservations.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}