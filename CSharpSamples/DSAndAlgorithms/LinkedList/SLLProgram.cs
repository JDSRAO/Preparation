using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.LinkedList
{
    public class SLLProgram : IProgram
    {
        public void Run()
        {
            Console.WriteLine("-- Singly Linked List --");
            SinglyLL<int> sll = new SinglyLL<int>();
            for (int i = 1; i <= 10; i++)
            {
                sll.Add(i);
            }
            sll.Print();
            Console.Write("Enter value to search: ");
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sll.Contains(item));
            Console.Write("Enter value to delete: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sll.Delete(item));
            sll.Print();
        }
    }
}
