using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DierenAsiel;

namespace ShelterTest
{
    [TestClass]
    public class DogTest
    {
        [TestMethod]
        public void TestCreateDog()
        {
            Date DateOfBirth = new Date(28, 09, 1996);
            Date LastWalkDate = new Date(15, 03, 2016);
            Dog dog = new Dog(55, "henk", 44, DateOfBirth, LastWalkDate);
            Assert.AreEqual(dog.RegistrationNumber, 55);
            Assert.AreEqual(dog.Name, "henk");
            Assert.AreEqual(dog.Price, 44);
            Assert.AreEqual(dog.DateOfBirth, DateOfBirth);
            Assert.AreEqual(dog.LastWalkDate, LastWalkDate);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCreateDogWichIsNull()
        {
            Dog dog = null;
            Assert.AreEqual(dog.RegistrationNumber, null);
            Assert.AreEqual(dog.Name, null);
            Assert.AreEqual(dog.Price, null);
            Assert.AreEqual(dog.DateOfBirth, null);
            Assert.AreEqual(dog.LastWalkDate, null);
        }
    }
}
