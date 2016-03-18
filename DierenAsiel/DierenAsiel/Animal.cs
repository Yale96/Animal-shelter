using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Animal
    {
        public int RegistrationNumber { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Date DateOfBirth { get; set; }
        public bool Reserved { get; set; }
        
        public Animal(int registrationNumber, string name, int price, Date dateOfBirth)
        {
            this.RegistrationNumber = registrationNumber;
            this.Name = name;
            this.Price = price;
            this.DateOfBirth = dateOfBirth;
            this.Reserved = false;
        }

        public override string ToString()
        {
            return string.Format("Registration number: {0}, Name: {1}, Price: {2}, Date of birth: {3}, Reserved: {4}", RegistrationNumber, Name, Price, DateOfBirth, Reserved);
        }
    }
}
