using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DierenAsiel;

namespace ShelterTest
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void TestCreateDate()
        {
            Date date = new Date(28, 09, 1996);
            Assert.AreEqual(date.Day, 28);
            Assert.AreEqual(date.Month, 09);
            Assert.AreEqual(date.Year, 1996);
        }

        [TestMethod]
        public void TestCreateDateInFuture()
        {
            Date date = new Date(28, 09, 2025);
            Assert.AreEqual(date.Day, 28);
            Assert.AreEqual(date.Month, 09);
            Assert.AreEqual(date.Year, 2025);
        }
    }
}
