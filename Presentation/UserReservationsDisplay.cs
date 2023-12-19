using DataAccess;
using Logic;

class ReservationInterface
{


    public static void DisplayUserReservations(Person loggedUser)
{   
    // Refresh logged-in user data from JSON
    Person refreshedUser = AccessData.GetUserByEmail(loggedUser.Email);
    if (refreshedUser != null)
    {
        loggedUser = refreshedUser;
    }
    {
        if (loggedUser.Reservations.Any())
        {
            Console.WriteLine("Your Reservations:");
            foreach (var reservation in loggedUser.Reservations)
            {
                if (reservation == null || reservation.ChairInfoList == null || string.IsNullOrEmpty(reservation.MovieName))
                {
                    Console.WriteLine("Invalid reservation data.");
                    continue;
                }

                Console.WriteLine($"Movie: {reservation.MovieName}, Hall: {reservation.Hall}");
                Console.WriteLine("Chairs: " + string.Join(", ", reservation.ChairInfoList.Select(chairInfo => $"Row {chairInfo.Row}, Chair {chairInfo.ChairInTheRow}")));
                Console.WriteLine($"Total Cost: €{reservation.totalCost:F2}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("You have no reservations.");
        }
    }
}

}

 