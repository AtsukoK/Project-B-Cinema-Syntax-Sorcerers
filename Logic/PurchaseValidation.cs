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

        if (!ExpirationDate(expirationDate))
        {
            Console.WriteLine("Invalid expiration date format. Please use MM/YY format.");
            return;
        }
        ExpirationDate(expirationDate);
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

    public static bool ExpirationDate(string expirationDate)
    {
        if (expirationDate.Length == 7 && expirationDate[3] == '/' &&
         expirationDate.Substring(0, 2).All(char.IsDigit) &&
         expirationDate.Substring(4).All(char.IsDigit) &&
         expirationDate.Substring(4).Length == 4)
        {
            return true;
        }
        return false;
    }
}