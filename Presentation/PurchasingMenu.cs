class PurchasingMenu
{
    public static void View()
    {
        Console.WriteLine("\nSelect payment method:\n");
        Console.WriteLine("1. Credit card\n2. Debit card");
        string userChoice = Console.ReadLine()!;

        switch (userChoice)
        {
            case "1":
                CreditCardInfo();
                Console.WriteLine("Press ENTER to confirm your purchase.");

                break;
            case "2":
                break;
        }
    }

    private static void CreditCardInfo()
    {
        Console.WriteLine("Please enter the following credit card information:\n");
        Validate.userNameCard();
        Validate.userCardInfo();
    }
}