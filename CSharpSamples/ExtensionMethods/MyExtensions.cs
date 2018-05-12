using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.ExtensionMethods
{
    public static class MyExtensions
    {
        public static int StringLength(this Employee emp)
        {
            if (emp.Name != null)
            {
                return emp.Name.Length;
            }
            return 0;
        }

        public static int Spaces(this string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char item = str[i];
                if (item.Equals(' '))
                {
                    count++;
                }
            }
            return count;
        }

        public static void Dummy(this ITest test)
        {
            Console.WriteLine("Hai I am from an extension methods");
        }

        public static void Dummy<T>(this List<T> test)
        {
            Console.WriteLine("Hai I am from an extension methods");
        }
    }
}
