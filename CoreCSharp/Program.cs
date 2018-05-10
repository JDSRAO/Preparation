using CSharpSamples.CodeFirstApproach;
using CSharpSamples.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodExtensions();
            EFCodeFirstApproach();
            Console.ReadLine();
        }

        static void MethodExtensions()
        {
            Employee emp = new Employee();
            emp.Name = "Hai I am an string";
            Console.WriteLine(emp.ToString());
            Console.WriteLine("Length: " + emp.StringLength());

            string str = "Hai I am an string";
            Console.WriteLine(str);
            Console.WriteLine("Spaces: " + str.Spaces());

            ITest test = new Test();
            test.Dummy();
        }

        static void EFCodeFirstApproach()
        {
            using (var context = new EFDbContext())
            {
                context.Database.Delete();
                context.Database.Create();
            }
        }
    }
}
