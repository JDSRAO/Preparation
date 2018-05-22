using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSamples.ExtensionMethods;

namespace CSharpSamples.RecursiveFunctions
{
    public class RFProgram : IProgram
    {
        public void Run()
        {
            List<int> set = new List<int>();
            int valueToFind = 8;
            for (int i = 0; i < 10; i++)
            {
                set.Add(i + 1);
            }

            set.Print();

            set.GetSubsets();
            Console.WriteLine("Index of {0} is {1}", valueToFind, set.BinaryASearch(valueToFind));

            string namesString = "KJDS SRINIVASA RAOa";
            char nameToFind = 'a';
            namesString.ToCharArray().ToList().Print();

            Console.WriteLine("Index of {0} is {1}", nameToFind.ToString(), namesString.ToCharArray().ToList().BinaryASearch(nameToFind));
        }
    }
}
