using DataAccess;
using Logic;
public class HallGeneration
{
    public static void HallGenerationMenu()
    {
        bool exit = false;

        while (!exit)
        {
            //Hall generation
            Console.WriteLine("Movie Hall Generation\n");
            Console.WriteLine("1.Small Size\n2.Medium Size\n3.Large Size");

            string choice = Console.ReadLine()!;
            switch (choice)
            {
                case "1":
                    // If user chooses small hall
                    HallCreation.GenerateSmallHall();
                    exit = true;
                    break;
                case "2":
                    // chooses medium hall
                    HallCreation.GenerateMediumHall();
                    break;
                case "3":
                    // chooses large hall
                    HallCreation.GenerateLargeHall();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter 1, 2, or 3.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}