using System;
using DierenAsiel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShelterTest
{
    [TestClass]
    public class ShelterTest
    {
        
        [TestMethod]
        public void TestAddAnimal()
        {
            Shelter shelter = new Shelter();
            Animal animal = new Animal(55, "Yannick", 55, new Date(28, 09, 1996));
            shelter.Add(animal);
            Assert.AreEqual(1, shelter.Animals.Count);
        }

        [TestMethod]
        public void TestAddAnimalWichIsNull()
        {
            Shelter shelter = new Shelter();
            Animal animal = null;
            shelter.Add(animal);
            Assert.AreEqual(0, shelter.Animals.Count);
        }

        [TestMethod]
        public void TestRemoveAnimal()
        {
            Shelter shelter = new Shelter();
            Animal animal = new Animal(55, "Yannick", 55, new Date(28, 09, 1996));
            shelter.Add(animal);
            shelter.removeAnimal(animal);
            Assert.AreEqual(0, shelter.Animals.Count);
        }

        [TestMethod]
        public void TestRemoveAnimalWichIsNull()
        {
            Shelter shelter = new Shelter();
            Animal animal = new Animal(55, "Yannick", 55, new Date(28, 09, 1996));
            Animal animalTwo = null;
            shelter.Add(animal);
            shelter.removeAnimal(animalTwo);
            Assert.AreEqual(1, shelter.Animals.Count);
        }
    }
}
