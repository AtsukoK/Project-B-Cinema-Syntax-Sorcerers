// switch (choice)
// {
//     case "1":
//         Console.WriteLine("Movie Listings:");

//         // Logic moet nog toegevoegd worden

//         Console.WriteLine("Press 'ENTER' to go back to the main menu...");
//         Console.ReadLine();
//         break;

//     case "2":
//         Console.WriteLine("Purchase Tickets:");

//         // Logic moet nog toegevoegd worden

//         Console.WriteLine("Press 'ENTER' to go back to the main menu...");
//         Console.ReadLine();
//         break;

//     case "3":
//         Console.WriteLine("Please enter password:");
//         string userPass = Console.ReadLine()!;
//         if (userPass == adminPassword)
//         {
//             isAdmin = true;
//             if (isAdmin)
//             {
//                 Console.WriteLine("\nWelcome to Admin Mode!");
//                 Console.WriteLine("Choose out of the following options:\n");
//                 Console.WriteLine("1. Manage Movies");
//                 Console.WriteLine("2. Manage Users");
//                 Console.WriteLine("3. Manage ticket prices\n");

//                 // Voeg meer opties als het nodig is
//                 string adminChoice = Console.ReadLine()!;
//                 Console.WriteLine();
//                 switch (adminChoice)
//                 {
//                     case "1":
//                         // Films beheren
//                         Console.WriteLine("Choose out of the following options:\n");
//                         Console.WriteLine("1. Add movie");
//                         Console.WriteLine("2. Delete movie\n");
//                         string adminOptions = Console.ReadLine()!;

//                         switch (adminOptions)
//                         {
//                             case "1":
//                                 // Logic moet nog toegevoegd worden
//                                 // Admin selecteerd welk films er toegevoegd worden
//                                 Console.WriteLine("test");
//                                 break;
//                             case "2":
//                                 // Logic moet nog toegevoegd worden
//                                 // Admin selecteerd welk films er verwijderd worden
//                                 break;
//                         }
//                         break;
//                     case "2":
//                         // Gebruikers beheren
//                         // Logic moet nog toegevoegd worden
//                         break;
//                     case "3":
//                         // Tickets beheren
//                         // Logic moet nog toegevoegd worden
//                         break;
//                     default:
//                         Console.WriteLine("Invalid option. Please enter number 1, 2 or 3.");
//                         Console.WriteLine("Press 'ENTER' to continue...");
//                         Console.ReadLine();
//                         break;
//                 }
//             }
//         }
//         else
//         {
//             Console.WriteLine("Incorrect password. Access denied\n");
//         }

//         Console.WriteLine("Press 'ENTER' to go back to the main menu...");
//         Console.ReadLine();
//         break;

//     case "4":
//         exit = true;
//         break;

//     default:
//         Console.WriteLine("Invalid option. Please enter number 1, 2 or 3.");
//         Console.WriteLine("Press 'ENTER' to continue...");
//         Console.ReadLine();
//         break;

// }