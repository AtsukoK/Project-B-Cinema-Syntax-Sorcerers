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
                Validate.iDealPayment();
                break;
        }
    }

    private static void CreditCardInfo()
    {
        Console.WriteLine("Please enter the following credit card information:\n");
        Validate.userCardInfo();
    }
}