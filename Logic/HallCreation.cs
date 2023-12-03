using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
public class HallCreation
{

    public static List<List<char>> GenerateSmallHall()
    {
        List<char> row1 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row2 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row3 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<char> row4 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'A', 'A', 'A', 'A', 'A' };

        List<char> row5 = new List<char> { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' };

        List<char> row6 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

        List<char> row7 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

        List<char> row8 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

        List<char> row9 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

        List<char> row10 = new List<char> { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' };

        List<char> row11 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'A', 'A', 'A', 'A', 'A' };

        List<char> row12 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<char> row13 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<char> row14 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<List<char>> rows = new List<List<char>>
            {
        row1,
        row2,
        row3,
        row4,
        row5,
        row6,
        row7,
        row8,
        row9,
        row10,
        row11,
        row12,
        row13,
        row14
        };
        return rows;
        // GenerateOverview(rows, $"hall1-{moviename}");
    }
    public static List<List<char>> GenerateMediumHall()
    {
        List<char> row1 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' };

        List<char> row2 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' };

        List<char> row3 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row4 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row5 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row6 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X' };

        List<char> row7 = new List<char> { 'X', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'X' };

        List<char> row8 = new List<char> { 'X', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'X' };

        List<char> row9 = new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A' };

        List<char> row10 = new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A' };

        List<char> row11 = new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A' };

        List<char> row12 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'A', 'A', 'A' };

        List<char> row13 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'A', 'A', 'A' };

        List<char> row14 = new List<char> { 'X', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'X' };

        List<char> row15 = new List<char> { 'X', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'X' };

        List<char> row16 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X' };

        List<char> row17 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X' };

        List<char> row18 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<char> row19 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<List<char>> rows = new List<List<char>>
            {
        row1,
        row2,
        row3,
        row4,
        row5,
        row6,
        row7,
        row8,
        row9,
        row10,
        row11,
        row12,
        row13,
        row14,
        row15,
        row16,
        row17,
        row18,
        row19
        };
        return rows;
        // GenerateOverview(rows, $"hall2-{moviename}"); ;
    }

    public static List<List<char>> GenerateLargeHall()
    {
        List<char> row1 = new List<char> { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X', 'X', 'X', 'X' };

        List<char> row2 = new List<char> { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X', 'X', 'X', 'X' };

        List<char> row3 = new List<char> { 'X', 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X', 'X' };

        List<char> row4 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' };

        List<char> row5 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' };

        List<char> row6 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row7 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row8 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<char> row9 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A' };

        List<char> row10 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A' };

        List<char> row11 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A' };

        List<char> row12 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A' };

        List<char> row13 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A' };

        List<char> row14 = new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X' };

        List<char> row15 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

        List<char> row16 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X', 'X', 'X' };

        List<char> row17 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' };

        List<char> row18 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X' };

        List<char> row19 = new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X' };

        List<char> row20 = new List<char> { 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X' };


        List<List<char>> rows = new List<List<char>>
            {
        row1,
        row2,
        row3,
        row4,
        row5,
        row6,
        row7,
        row8,
        row9,
        row10,
        row11,
        row12,
        row13,
        row14,
        row15,
        row16,
        row17,
        row18,
        row19,
        row20
        };
        return rows;
        // GenerateOverview(rows, $"hall3-{moviename}"); ;
    }


    public static void ColorChanger(Chair chair)
    {
        if (chair.Price == 1.0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (chair.Price == 1.05)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        else if (chair.Price == 1.10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (chair.Price == 0)
        {
            Console.ResetColor();
        }
    }
    public static List<Chair> GenerateOverview(List<List<char>> list, String moviename)
    {
        List<List<char>> rows = list;
        int currentROW = 1;
        int currentID = 1;

        List<Chair> allchairs = new List<Chair> { };
        foreach (var row in rows)
        {
            foreach (var character in row)
            {
                if (character == 'A')
                {
                    Chair chair = new Chair(currentID, 1.0, false, currentROW);
                    currentID++;
                    allchairs.Add(chair);
                }
                else if (character == 'B')
                {
                    Chair chair = new Chair(currentID, 1.05, false, currentROW);
                    currentID++;
                    allchairs.Add(chair);
                }
                else if (character == 'C')
                {
                    Chair chair = new Chair(currentID, 1.10, false, currentROW);
                    currentID++;
                    allchairs.Add(chair);
                }
                else if (character == 'X')
                {
                    Chair chair = new Chair(0, 0, false, currentROW);
                    allchairs.Add(chair);
                }

            }
            currentROW++;
        }

        currentROW = 1;
        int currentChairIndex = 0;

        while (currentChairIndex < allchairs.Count)
        {
            if (allchairs[currentChairIndex].Row == currentROW)
            {
                Chair chair = allchairs[currentChairIndex];

                if (chair.ID == 0)
                {
                    ColorChanger(chair);
                    Console.Write(" [---] ");
                    Console.ResetColor();
                }
                else if (chair.ID < 10)
                {
                    ColorChanger(chair);
                    Console.Write($" [00{chair.ID}] ");
                    Console.ResetColor();
                }
                else if (chair.ID < 100)
                {
                    ColorChanger(chair);
                    Console.Write($" [0{chair.ID}] ");
                    Console.ResetColor();
                }
                else
                {
                    ColorChanger(chair);
                    Console.Write($" [{chair.ID}] ");
                    Console.ResetColor();
                }

                currentChairIndex++;
            }
            else
            {
                Console.WriteLine();
                currentROW++;
            }
        }
        Console.WriteLine("\n");


        string updatedJson = JsonConvert.SerializeObject(allchairs, Formatting.Indented);
        string jsonFilePath = Path.Combine("Datasources", moviename); // Datasource/filename
        File.WriteAllText(jsonFilePath, updatedJson);

        return allchairs;
    }

}
