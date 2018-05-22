using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Attributes
{
    public class AttributeProgram : IProgram
    {
        [MyAttribute("My Url", Title = "Attribute Program from attribute")]
        public void Run()
        {
            Console.WriteLine("Attibute Program from run");
        }
    }
}
