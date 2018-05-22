using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Operators
{
    public class Employee
    {
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private string name;
        private string department;
        private string city;

        public Employee(string name, string dept, string city)
        {
            this.name = name;
            this.department = dept;
            this.city = city;
        }

        public Employee()
        {
            
        }

        public static bool operator ==(Employee e1, Employee e2) => Equals(e1,e2);

        public static bool operator !=(Employee e1, Employee e2) => Equals(e1,e2);

        public override bool Equals(object other) => Equals(this, other as Employee);

        public override string ToString()
        {
            return $"{name}, {department}, {city}";
        }


        private static bool Equals(Employee a, Employee b)
        {
            if (Object.ReferenceEquals(a, null))
            {
                return Object.ReferenceEquals(b, null);
            }
            if (Object.ReferenceEquals(b, null))
            {
                return false;
            }

            if (a.name.Equals(b.name) && a.department.Equals(b.department) && a.city.Equals(b.city))
            {
                return true;
            }

            return false;

        }
    
    }
}
