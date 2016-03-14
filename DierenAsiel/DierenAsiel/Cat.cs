using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenAsiel
{
    public class Cat:Animal
    {
        public string Information { get; set; }
        
        public Cat(int registrationNumber, string name, int price, Date dateOfBirth, string information) :base(registrationNumber, name, price, dateOfBirth)
        {
            this.Information = information;
        }

        public override string ToString()
        {
            return string.Format("Cat: {0}, Information: {1}", base.ToString(), Information);
        }
    }
}
