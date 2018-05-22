using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.BST
{
    public class BSTProgram : IProgram
    {
        public void Run()
        {
            Console.WriteLine("-- BST --");
            int item;
            BST<int> bst = new BST<int>();
            for (int i = 1; i <= 10; i++)
            {
                //bst.Add(GenerateRandom());
                bst.Add(i);
            }
            bst.Print();
            Console.Write("Enter value to search: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contains {0} : {1}", item, bst.Contains(item));
        }
    }
}
