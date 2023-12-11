using System.Threading.Tasks.Dataflow;

class HallDisplay
{
    public static void DisplayHall(Show showobject)
    {
        List<Chair> allchairs = showobject.Chairs;
        int currentROW = 1;
        int currentChairIndex = 0;

        while (currentChairIndex < allchairs.Count)
        {
            if (allchairs[currentChairIndex].Row == currentROW)
            {
                Chair chair = allchairs[currentChairIndex];
                if (chair.IsReserved == true)
                {
                    Console.Write("[RE]");
                    Console.ResetColor();
                }

                else if (chair.ID == 0)
                {
                    HallCreation.ColorChanger(chair);
                    Console.Write("[--]");
                    Console.ResetColor();
                }
                else if (chair.ID < 10)
                {
                    if (chair.ChairInTheRow < 10)
                    {
                        Console.Write($"[0{chair.ChairInTheRow}]");
                    }
                    else
                    {
                        Console.Write($"[{chair.ChairInTheRow}]");
                    }
                    Console.ResetColor();
                }
                else if (chair.ID < 100)
                {
                    HallCreation.ColorChanger(chair);
                    if (chair.ChairInTheRow < 10)
                    {
                        Console.Write($"[0{chair.ChairInTheRow}]");
                    }
                    else
                    {
                        Console.Write($"[{chair.ChairInTheRow}]");
                    }
                    Console.ResetColor();
                }
                else
                {
                    HallCreation.ColorChanger(chair);
                    if (chair.ChairInTheRow < 10)
                    {
                        Console.Write($"[0{chair.ChairInTheRow}]");
                    }
                    else
                    {
                        Console.Write($"[{chair.ChairInTheRow}]");
                    }
                    Console.ResetColor();
                }

                currentChairIndex++;
            }
            else
            {
                Console.Write($" (ROW)[{currentROW}]");
                Console.WriteLine();
                currentROW++;
            }
        }
        Console.Write($" (ROW)[{currentROW}]");
        Console.WriteLine("\n");
    }

    public static void CheckIsReserved()
    {

    }
}