using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.OOP
{
    public class OOPProgram : IProgram
    {
        public void Run()
        {
            Employee emp = new Employee();
            emp.Name = "KJDS";

            Employee emp1 = new Employee()
            {
                Name = "KJDS",
                Address = "Bangalore",
                Department = "IT",
                Email = "kjdssrinivasarao@gmail.com",
                DOB = new DateTime(1993,12,17),
                IsPermanent = true
            };

            HREmoployee emp2 = new HREmoployee() { Name = "emp2" };
            Console.WriteLine(emp2.GetDepartment(11));
            Console.WriteLine(emp2.GetName());
            Console.WriteLine(emp2.GetAge());

            Employee emp3 = new HREmoployee() { Name = "emp3" };
            Console.WriteLine(emp3.GetDepartment());
            Console.WriteLine(emp3.GetName());


            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp.ToString());
        }
    }
}
