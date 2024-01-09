using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic
{
    [TestClass]
    public class AccountValidationTests
    {
        [TestMethod]
        public void ValidateEmail_Valid()
        {
            string email = "test@example.com";

            bool result = AccountValidation.ValidateEmail(email);

            Assert.IsTrue(result);
        }
        // email is valid

        [TestMethod]
        public void ValidateEmail_Invalid()
        {
            string email = "invalid_email_format";

            bool result = AccountValidation.ValidateEmail(email);

            Assert.IsFalse(result);
        }
        //niet valid (verkeerde format)

        [TestMethod]
        public void ValidateName_Valid()
        {
            string name = "Sara";

            bool result = AccountValidation.ValidateName(name);

            Assert.IsTrue(result);
        }
        // name is valid

        [TestMethod]
        public void ValidateName_Invalid()
        {
            string name = "";

            bool result = AccountValidation.ValidateName(name);

            Assert.IsFalse(result);
        }
        //lege string => niet valid

        [TestMethod]
        public void ValidatePassword_Valid()
        {
            string password = "Abc123Efg!";

            string result = AccountValidation.ValidatePassword(password);

            Assert.IsNull(result);
        }
        //wachtwoord is valid

        [TestMethod]
        public void ValidatePassword_Invalid_Length()
        {
            string password = "Short";

            string result = AccountValidation.ValidatePassword(password);

            Assert.AreEqual("Password must be at least 8 characters long.", result);
        }
        //wachtwoord is te kort => niet valid

        [TestMethod]
        public void ValidatePassword_Invalid_Uppercase()
        {
            string password = "lowercase123!";

            string result = AccountValidation.ValidatePassword(password);

            Assert.AreEqual("Password must contain at least one uppercase letter.", result);
        }
        //wachtwoord heeft geen hoofdletter => niet valid

        [TestMethod]
        public void ValidatePassword_Invalid_Lowercase()
        {
            string password = "UPPERCASE123!";

            string result = AccountValidation.ValidatePassword(password);

            Assert.AreEqual("Password must contain at least one lowercase letter.", result);
        }
        //wachtwoord heeft geen kleine letter => niet valid

        [TestMethod]
        public void ValidatePassword_Invalid_Digit()
        {
            string password = "NoDigit!";

            string result = AccountValidation.ValidatePassword(password);

            Assert.AreEqual("Password must contain at least one digit.", result);
        }
        //wachtwoord heeft geen cijfer => niet valid

        [TestMethod]
        public void ValidatePassword_Invalid_SpecialCharacter()
        {
            string password = "NoSpecialCharacter123";

            string result = AccountValidation.ValidatePassword(password);

            Assert.AreEqual("Password must contain at least one special character.", result);
        }
        //wachtwoord heeft geen speciaal teken => niet valid

        [TestMethod]
        public void ValidatePhone_EmptyPhoneNumber()
        {
            string phoneNumber = "";

            bool result = AccountValidation.ValidatePhone(phoneNumber);

            Assert.IsTrue(result);
        }
        //telefoonnummer is leeg => valid (want niet verplicht)

        [TestMethod]
        public void ValidatePhone_InvalidPhoneNumber()
        {
            string phoneNumber = "12345";

            bool result = AccountValidation.ValidatePhone(phoneNumber);

            Assert.IsFalse(result);
        }
        //telefoonnummer is te kort => niet valid

        [TestMethod]
        public void ValidatePhone_InvalidPhoneNumber2()
        {
            string phoneNumber = "12345abcde";

            bool result = AccountValidation.ValidatePhone(phoneNumber);

            Assert.IsFalse(result);
        }
        //telefoonnummer heeft letters => niet valid

    }
}
