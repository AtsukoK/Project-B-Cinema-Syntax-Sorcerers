using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

class HallDisplay
{
    public static void DisplayHall(Show showobject)
    {
        List<Chair> allchairs = showobject.Chairs;
        int currentROW = 0;
        int IteratedChairs = 0;
        int countChairs = 0;
        int MaxChairs = 0;
        int MaxChairsPerRow = 0;

        int halltype = showobject.HallType;
        if (halltype == 1)
        {
            currentROW = 14;
            MaxChairs = 168;
            MaxChairsPerRow = 12;
        }
        if (halltype == 2)
        {
            currentROW = 19;
            MaxChairs = 342;
            MaxChairsPerRow = 18;
        }
        if (halltype == 3)
        {
            currentROW = 20;
            MaxChairs = 600;
            MaxChairsPerRow = 30;
        }


        while (IteratedChairs < MaxChairs)
        {

            foreach (Chair chair in allchairs)
            {

                if (countChairs == MaxChairsPerRow)
                {
                    Console.WriteLine($" | ROW {currentROW} ");
                    currentROW--;
                    countChairs = 0;
                }


                if (chair.Row == currentROW)
                {
                    if (chair.ID == 0)
                    {
                        HallCreation.ColorChanger(chair);
                        Console.Write($"[--]");
                        IteratedChairs++;
                        countChairs++;
                        Console.ResetColor();
                    }
                    else if (chair.IsReserved == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"[RE]");
                        IteratedChairs++;
                        countChairs++;
                        Console.ResetColor();
                    }
                    else if (chair.ChairInTheRow < 10)
                    {
                        HallCreation.ColorChanger(chair);
                        Console.Write($"[0{chair.ChairInTheRow}]");
                        IteratedChairs++;
                        countChairs++;
                        Console.ResetColor();
                    }
                    else
                    {
                        HallCreation.ColorChanger(chair);
                        Console.Write($"[{chair.ChairInTheRow}]");
                        IteratedChairs++;
                        countChairs++;
                        Console.ResetColor();
                    }

                }

            }

        }
    }
}