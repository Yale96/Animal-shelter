using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DierenAsiel;

namespace ShelterTest
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void TestCreateCat()
        {
            Date dateOfBirth = new Date(28, 09, 1996);
            Cat cat = new Cat(25, "Yannick", 25, dateOfBirth, "Is net nieuw");
            Assert.AreEqual(cat.RegistrationNumber, 25);
            Assert.AreEqual(cat.Name, "Yannick");
            Assert.AreEqual(cat.Price, 25);
            Assert.AreEqual(cat.DateOfBirth, dateOfBirth);
            Assert.AreEqual(cat.Information, "Is net nieuw");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCreateCatWichIsNull()
        {
            Cat cat = null;
            Assert.AreEqual(cat.RegistrationNumber, null);
            Assert.AreEqual(cat.Name, null);
            Assert.AreEqual(cat.Price, null);
            Assert.AreEqual(cat.DateOfBirth, null);
            Assert.AreEqual(cat.Information, null);
        }
    }
}
