using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Dog:Animal
    {
        public Date LastWalkDate { get; set; }
        public Dog(int registrationNumber, string name, int price, Date dateOfBirth, Date lastWalkDate) :base(registrationNumber, name, price, dateOfBirth)
        {
            this.LastWalkDate = lastWalkDate;
        }

        public override string ToString()
        {
            return string.Format("Dog: {0}, Last walk date: {1}", base.ToString(), LastWalkDate);
        }
    }
}
