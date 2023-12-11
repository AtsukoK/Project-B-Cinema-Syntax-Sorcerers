class PurchasingMenu
{
    public static void View()
    {
        Console.WriteLine("\nSelect payment method:\n");
        Console.WriteLine("1. Credit card\n2. iDEAL");
        string userChoice = Console.ReadLine()!;

        switch (userChoice)
        {
            case "1":
                CreditCardInfo();
                Validate.ConfirmPurchase();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Choose your Bank:\n");
                Console.WriteLine("1. ABN AMBRO\n2. ING\n3. Rabobank");
                string choice = Console.ReadLine()!;
                Console.Clear();
                // error handling of bank input
                Validate.iDealPayment();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Incorrect input, please select option 1 or 2 again.");
                PurchasingMenu.View();
                break;
        }
    }

    private static void CreditCardInfo()
    {
        Console.Clear();
        Console.WriteLine("Please enter the following credit card information:\n");
        Validate.userCardInfo();
    }
}