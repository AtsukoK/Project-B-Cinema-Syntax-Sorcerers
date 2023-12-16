using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logic.Tests
{
    [TestClass]
    public class PurchasingValidationTests
    {
        [TestMethod]
        public void UserCardInfo_Valid()
        {
            // arrange
            string cardNumber = "1234567891234567";
            string cardholderName = "Sara";
            string expirationDate = "12/2021";

            // verwachtte resultaat
            bool expectedValidCardNum = true;

            // capture en redirect console input/output
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            StringReader stringReader = new StringReader($"{cardholderName}\n{expirationDate}");
            Console.SetIn(stringReader);

            // act
            Validate.userCardInfo();
            // user input simuleren

            string consoleOutput = stringWriter.ToString();

            bool actualValidCardNum = consoleOutput.Contains("Payment successful!");

            // assert
            Assert.AreEqual(expectedValidCardNum, actualValidCardNum);
        }

        [TestMethod]
        public void UserCardInfo_Invalid()
        {

            // arrange
            string cardNumber = "1234";
            string cardholderName = "";
            string expirationDate = "13/2022";

            // verwachtte resultaat
            bool expectedValidCardNum = false;

            // capture and redirect console input/output
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            StringReader stringReader = new StringReader($"{cardholderName}\n{expirationDate}");
            Console.SetIn(stringReader);

            // act
            Validate.userCardInfo();
            // user input simuleren

            string consoleOutput = stringWriter.ToString();

            bool actualValidCardNum = consoleOutput.Contains("Invalid card number") && consoleOutput.Contains("Invalid cardholder name");

            // assert
            Assert.AreEqual(expectedValidCardNum, actualValidCardNum);
        }

        [TestMethod]
        public void UserCardInfo_Invalid2()
        {
            string cardNumber = "1234";
            string cardholderName = "";
            string expirationDate = "13/2022";
            // alle informatie is invalid

            // verwachtte resultaat
            bool expectedValidCardNum = false;

            // capture and redirect console input/output
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            StringReader stringReader = new StringReader($"{cardholderName}\n{expirationDate}");
            Console.SetIn(stringReader);

            // act
            Validate.userCardInfo();
            //user input simuleren

            string consoleOutput = stringWriter.ToString();

            bool actualValidCardNum = consoleOutput.Contains("Invalid card number") && consoleOutput.Contains("Invalid cardholder name");

            // assert
            Assert.AreEqual(expectedValidCardNum, actualValidCardNum);
        }
    }
}

