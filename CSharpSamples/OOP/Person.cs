using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.OOP
{
    public abstract class Person //asbtraction
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        public Person(string name, string address, string email, DateTime dob)
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.DOB = dob;
        }

        public Person()
        {

        }
    }
}
