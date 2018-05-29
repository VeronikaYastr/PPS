using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAuthorization
    {
        [TestMethod]
        public void TestСorrectLogin()
        {
            string login = "hey@mail.ru";
            bool expectedResult = UniversitySite.LoginController.CheckLogin(login);
            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        public void TestEmptyLogin()
        {
            string login = "";
            bool expectedResult = UniversitySite.LoginController.CheckLogin(login);
            Assert.IsFalse(expectedResult);
        }

        [TestMethod]
        public void TestTooLargeLogin()
        {
            string login = "veryveryveryveryveryverybiglogin";
            bool expectedResult = UniversitySite.LoginController.CheckLogin(login);
            Assert.IsFalse(expectedResult);
        }

        [TestMethod]
        public void TestCorrectPassword()
        {
            string password = "hey";
            bool expectedResult = UniversitySite.LoginController.CheckPassword(password);
            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        public void TestEmptyPassword()
        {
            string password = "";
            bool expectedResult = UniversitySite.LoginController.CheckPassword(password);
            Assert.IsFalse(expectedResult);
        }

        [TestMethod]
        public void TestTooLargePassword()
        {
            string password = "veryveryveryveryveryverybigpassword";
            bool expectedResult = UniversitySite.LoginController.CheckPassword(password);
            Assert.IsFalse(expectedResult);
        }
    }
}
