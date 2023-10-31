using System.Runtime.CompilerServices;

List<char> row1 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

List<char> row2 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

List<char> row3 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

List<char> row4 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'A', 'A', 'A', 'A', 'A' };

List<char> row5 = new List<char> { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' };

List<char> row6 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

List<char> row7 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

List<char> row8 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

List<char> row9 = new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' };

List<char> row10 = new List<char> { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' };

List<char> row11 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'A', 'A', 'A', 'A', 'A' };

List<char> row12 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' };

List<char> row13 = new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' };

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

foreach (var row in rows)
{
    foreach (var character in row)
    {
        if (character == 'A')
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (character == 'B')
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (character == 'C')
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.Write(character);

        // Reset the color back to the original
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}