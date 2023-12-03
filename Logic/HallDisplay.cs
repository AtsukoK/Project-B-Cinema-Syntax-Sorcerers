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
                    Console.Write("[RES]");
                    Console.ResetColor();
                    // break;
                }

                else if (chair.ID == 0)
                {
                    HallCreation.ColorChanger(chair);
                    Console.Write("[---]");
                    Console.ResetColor();
                }
                else if (chair.ID < 10)
                {
                    HallCreation.ColorChanger(chair);
                    Console.Write($"[00{chair.ID}]");
                    Console.ResetColor();
                }
                else if (chair.ID < 100)
                {
                    HallCreation.ColorChanger(chair);
                    Console.Write($"[0{chair.ID}]");
                    Console.ResetColor();
                }
                else
                {
                    HallCreation.ColorChanger(chair);
                    Console.Write($"[{chair.ID}]");
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