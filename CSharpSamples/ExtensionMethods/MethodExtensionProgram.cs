using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.ExtensionMethods
{
    public class MethodExtensionProgram : IProgram
    {
        public void Run()
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
    }
}
