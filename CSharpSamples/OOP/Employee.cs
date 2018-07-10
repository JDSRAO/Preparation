using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.OOP
{
    public class Employee : Person
    {
        public string Department { get; set; }
        public bool IsPermanent { get; set; }
        public TimeSpan Age
        {
            get
            {
                return DateTime.Now.Date - this.DOB.Date;
            }
        }

        public Employee(string name, string address, string email, DateTime dob) : base(name, address, email, dob)
        {

        }

        public Employee()
        {

        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Email}, {this.Address}, {this.Department}, {this.Age.TotalHours}, {this.IsPermanent}";
        }

        public string GetAge()
        {
            return $"{this.Name} Age from Employee";
        }

        public string GetDepartment()
        {
            return $"{this.Name} department from Employee";
        }

        public virtual string GetName()
        {
            return $"{this.Name} name from Employee";
        }
    }
}
