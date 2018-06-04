using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.LINQ
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
    }

    public class CompositeQueryDataClass
    {
        public static void CompositeKeyJoinExample()
        {
            // Create a list of employees.
            List<Employee> employees = new List<Employee> {
        new Employee { FirstName = "Terry", LastName = "Adams", EmployeeID = 522459 },
         new Employee { FirstName = "Charlotte", LastName = "Weiss", EmployeeID = 204467 },
         new Employee { FirstName = "Magnus", LastName = "Hedland", EmployeeID = 866200 },
         new Employee { FirstName = "Vernette", LastName = "Price", EmployeeID = 437139 } };

            // Create a list of students.
            List<Student> students = new List<Student> {
        new Student { FirstName = "Vernette", LastName = "Price", StudentID = 9562 },
        new Student { FirstName = "Terry", LastName = "Earls", StudentID = 9870 },
        new Student { FirstName = "Terry", LastName = "Adams", StudentID = 9913 } };

            // Join the two data sources based on a composite key consisting of first and last name,
            // to determine which employees are also students.
            IEnumerable<string> query = from employee in employees
                                        join student in students
                                        on new { employee.FirstName, employee.LastName }
                                        equals new { student.FirstName, student.LastName }
                                        select employee.FirstName + " " + employee.LastName;

            Console.WriteLine("The following people are both employees and students:");
            foreach (string name in query)
                Console.WriteLine(name);
        }

    }
}
