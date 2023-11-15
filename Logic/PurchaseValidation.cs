class Validate
{
    public static void userCardInfo()
    {
        bool validCardNum = false;

        while (!validCardNum)
        {
            Console.Write("Card Number (16-digits): ");
            string cardNumber = Console.ReadLine()!;

            if (cardNumber.Length == 16 && cardNumber.All(char.IsDigit))
            {
                validCardNum = true;
            }
            else
            {
                Console.WriteLine("Invalid card number. Card number must be 16-digits long and contain only digits.");
            }
        }

        string cardholderName = userNameCard()!;

        if (cardholderName == null)
        {
            Console.WriteLine("Invalid cardholder name. Name cannot be empty or too short.");
            return;
        }

        Console.Write("Expiration Date (MM/YYYY): ");
        string expirationDate = Console.ReadLine()!;
        string[] dates = expirationDate.Split('/');
        int[] ints = Array.ConvertAll(dates, int.Parse);
        int month = ints[0];
        int year = ints[1];
        IsValidDate(month, year);
    }

    private static bool IsValidDate(int month, int year)
    {
        if (year < DateTime.MinValue.Year || year > DateTime.MaxValue.Year)
            return false;

        if (month < 1 || year >= 2023)
            return false;

        return month > 0 && year <= DateTime.DaysInMonth(month, year);
    }

    public static string? userNameCard()
    {
        Console.Write("Full Name: ");
        string cardholderName = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(cardholderName) || cardholderName.Length < 4)
        {
            return null;
        }
        return cardholderName;
    }
}