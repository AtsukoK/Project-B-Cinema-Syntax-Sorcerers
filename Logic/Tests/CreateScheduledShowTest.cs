using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

// niet af idk of hij werkt heb ook nog niet getest
namespace ProjectB.Cinema.Tests
{
    [TestClass]
    public class ScheduleTests
    {
        [TestMethod]
        public void Test_GetDateTime()
        {
            // Arrange
            // mock input/output
            string[] inputs = { "20/12/2024", "15:30" };
            var mockConsole = new MockConsole(inputs);

            // Act
            Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            DateTime? result = Schedule.GetDateTime();

            // Assert
            Assert.AreEqual(new DateTime(2024, 12, 20, 15, 30, 0), result);
        }
    }

    public class MockConsole
    {
        private readonly string[] inputs;
        private int currentIndex;

        public MockConsole(string[] inputs)
        {
            this.inputs = inputs;
            currentIndex = 0;
        }

        public string ReadLine()
        {
            if (currentIndex < inputs.Length)
            {
                return inputs[currentIndex++];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}