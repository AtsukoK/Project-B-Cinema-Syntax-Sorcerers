using System.Runtime.CompilerServices;
public class SmallHallCreation
{

    public static List<Chair> GenerateSmallHall()
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

        int currentROW = 1;
        int currentID = 1;

        List<Chair> allchairs = new List<Chair> { };
        foreach (var row in rows)
        {
            foreach (var character in row)
            {
                if (character == 'A')
                {
                    Chair chair = new Chair(currentID, 100, false, currentROW);
                    currentID++;
                    allchairs.Add(chair);
                }
                else if (character == 'B')
                {
                    Chair chair = new Chair(currentID, 105, false, currentROW);
                    currentID++;
                    allchairs.Add(chair);
                }
                else if (character == 'C')
                {
                    Chair chair = new Chair(currentID, 110, false, currentROW);
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
        return allchairs;
    }
}