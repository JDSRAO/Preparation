using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class MyAttribute : Attribute
    {
        public string Url => url;
        public string Title { get; set; }

        private string url;

        public MyAttribute(string url)
        {
            this.url = url;
            Console.WriteLine($"{url} \n {Title}");
        }
    }
}
