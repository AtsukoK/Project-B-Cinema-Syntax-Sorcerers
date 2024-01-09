using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[TestClass]
public class HallCreationTests
{
    [TestMethod]
    public void GenerateSmallHall_Valid()
    {
        // arrange
        List<List<char>> expectedHall = new List<List<char>>
        {
            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'B', 'B', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' }
            // de rest van de rows nog toevoegen
        };

        // act
        List<List<char>> actualHall = HallCreation.GenerateSmallHall();

        // assert
        CollectionAssert.AreEqual(expectedHall, actualHall);
    }

    [TestMethod]
    public void GenerateMediumHall_Valid()
    {
        // arrange
        List<List<char>> expectedHall = new List<List<char>>
        {
            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'X' },

            new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A' },

            new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A' },

            new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'A', 'A', 'A' },

            new List<char> { 'X', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' }

        };

        // act
        List<List<char>> actualHall = HallCreation.GenerateMediumHall();

        // assert
        CollectionAssert.AreEqual(expectedHall, actualHall);
    }

    [TestMethod]
    public void GenerateLargeHall_Valid()
    {
        // arrange
        List<List<char>> expectedHall = new List<List<char>>
        {
            new List<char> { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A' },

            new List<char> { 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X' },

            new List<char> { 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'C', 'C', 'C', 'C', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'B', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X' },

            new List<char> { 'X', 'X', 'X', 'X', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'X', 'X', 'X', 'X' }
            // weer hetzelfde ^^
        };

        // act
        List<List<char>> actualHall = HallCreation.GenerateLargeHall();

        // assert
        CollectionAssert.AreEqual(expectedHall, actualHall);
    }

    [TestMethod]
    public void ColorChanger_SetConsoleColorToBlue()
    {
        // Arrange
        Chair chair = new Chair(1, 1.0, false, 1);

        // Act
        HallCreation.ColorChanger(chair);

        // Assert
        Assert.AreEqual(ConsoleColor.Blue, Console.ForegroundColor);
    }

    [TestMethod]
    public void ColorChanger_SetConsoleColorToDarkYellow()
    {
        // Arrange
        Chair chair = new Chair(1, 1.05, false, 1);

        // Act
        HallCreation.ColorChanger(chair);

        // Assert
        Assert.AreEqual(ConsoleColor.DarkYellow, Console.ForegroundColor);
    }

    [TestMethod]
    public void ColorChanger_SetConsoleColorToRed()
    {
        // Arrange
        Chair chair = new Chair(1, 1.10, false, 1);

        // Act
        HallCreation.ColorChanger(chair);

        // Assert
        Assert.AreEqual(ConsoleColor.Red, Console.ForegroundColor);
    }

    [TestMethod]
    public void ColorChanger_ResetConsoleColor()
    {
        // Arrange
        Chair chair = new Chair(1, 0, false, 1);

        // Act
        HallCreation.ColorChanger(chair);

        // Assert
        Assert.AreEqual(ConsoleColor.White, Console.ForegroundColor);
    }



    [TestMethod]
    public void GenerateOverview_Valid()
    {
        // Arrange
        // voeg alle chairs toe aan de list
        List<List<char>> list = new List<List<char>>
        {
            new List<char> { 'A', 'A', 'A' },

            new List<char> { 'B', 'B', 'B' },

            new List<char> { 'C', 'C', 'C' },

            new List<char> { 'X', 'X', 'X' }
        };
        string moviename = "test-movie";

        // Act
        List<Chair> result = HallCreation.GenerateOverview(list, moviename);

        // Assert
        Assert.AreEqual(9, result.Count);
    }
}
