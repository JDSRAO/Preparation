using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.ExtensionMethods
{
    public class Employee : IEquatable<Employee>, IComparable<Employee>
    {
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            return Name.Length - other.Name.Length;
        }

        public bool Equals(Employee other)
        {
            if (Name.Equals(other.Name))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Name;
        }

        public Employee(Departments dept)
        {
            Console.WriteLine(dept);
        }

        public Employee()
        {

        }
    }

    [System.FlagsAttribute]
    public enum Departments
    {
        None = 0,
        IT = 1
    }
}
