using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Delegate
{
    public class DelegateTest
    {
        public delegate void Function(double x);
        public event Function YourFunction;

        public DelegateTest()
        {
            
        }
    }
}
