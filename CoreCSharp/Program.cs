using CSharpSamples.CodeFirstApproach;
using CSharpSamples.ExtensionMethods;
using CSharpSamples.RecursiveFunctions;
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
            //EFCodeFirstApproach();
            RecursiveFunctions();
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

            List<int> set = new List<int>();
            set.Dummy<int>();
        }

        static void EFCodeFirstApproach()
        {
            using (var context = new EFDbContext())
            {
                //context.Database.sq
                context.Database.Delete();
                context.Database.Create();
            }
        }

        static void RecursiveFunctions()
        {
            List<int> set = new List<int>();
            int valueToFind = 8;
            for (int i = 0; i < 10; i++)
            {
                set.Add(i + 1);
            }
            //set.GetSubsets();
            //Console.WriteLine("Index of {0} is {1}", valueToFind, set.BinaryASearch(valueToFind));


            
            string namesString = "KJDS SRINIVASA RAOa";
            char nameToFind = 'a';
            namesString.ToCharArray().ToList();

            Console.WriteLine("Index of {0} is {1}", nameToFind.ToString(), namesString.ToCharArray().ToList().BinaryASearch(nameToFind));

        }
    }
}
