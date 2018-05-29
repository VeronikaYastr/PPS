using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestVerification
    {
        [TestMethod]
        public void TestRightAccess()
        {
            bool expected = UniversitySite.CheckingInfo.CheckAccess(UniversitySite.TypeOfUser.university_worker, UniversitySite.TypeOfRequest.updateInfo);
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestAccessIsDenied()
        {
            bool expected = UniversitySite.CheckingInfo.CheckAccess(UniversitySite.TypeOfUser.applicant, UniversitySite.TypeOfRequest.addInfo);
            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void TestCorrectYear()
        {
            string year = "2012";
            bool expected = UniversitySite.CheckingInfo.CheckCorectness(year);
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestEmptyYear()
        {
            string year = "";
            bool expected = UniversitySite.CheckingInfo.CheckCorectness(year);
            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void TestInvalidFormatYear()
        {
            string year = "2nn9";
            bool expected = UniversitySite.CheckingInfo.CheckCorectness(year);
            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void TestInvalidYear()
        {
            string year = "2100";
            bool expected = UniversitySite.CheckingInfo.CheckCorectness(year);
            Assert.IsFalse(expected);
        }
    }
}
