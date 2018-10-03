using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.Generics
{
    public class GenericDictrionaey<TKey, TValue> where TKey : struct //, where TValue : class
    {
        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    public partial class Utilities
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
