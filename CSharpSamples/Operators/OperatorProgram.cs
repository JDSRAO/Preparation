using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Operators
{
    public class OperatorProgram : IProgram
    {
        public void Run()
        {
            Employee e1 = new Employee()
            {
                Name = "KJDS",
                Department = "IT",
                City = "Los Angeles"
            };

            Employee e2 = new Employee()
            {
                Name = "KJDS1",
                Department = "IT",
                City = "Los Angeles"
            };

            Console.WriteLine($"Is {e1.ToString()} == {e2.ToString()} {e1 == e2}");
        }
    }
}
