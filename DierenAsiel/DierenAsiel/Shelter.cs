using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Shelter
    {
        public List<Animal> Animals { get; set; }

        public Shelter()
        {
            Animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            if(animal == null )
            {
                return false;
            }
            else
            {
                Animals.Add(animal);
                return true;
            }
        }
        
        public Animal FindAnimal(int registrationNumber)
        {
            Animal animalToReturn = null;
            foreach(Animal animal in Animals)
            {
                if(animal.RegistrationNumber == registrationNumber)
                {
                    animalToReturn = animal;
                }
            }
            return animalToReturn;
        }

        public bool removeAnimal(Animal animal)
        {
            if(animal == null)
            {
                return false;
            }
            else
            {
                Animals.Remove(FindAnimal(animal.RegistrationNumber));
                return true;
            }
        }
    }
}
