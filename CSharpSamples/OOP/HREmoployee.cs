using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.OOP
{
    public class HREmoployee : Employee
    {
        public string Office { get; set; }

        // Method Hiding
        public new string GetAge()
        {
            return $"{this.Name} Age from HREmoployee";
        }

        // Polymorphism - Method overloading
        public string GetDepartment(int a)
        {
            return $"{this.Name} department from HREmoployee";
        }

        public override string GetName()
        {
            return $"{this.Name} name from HREmoployee";
        }
    }
}
