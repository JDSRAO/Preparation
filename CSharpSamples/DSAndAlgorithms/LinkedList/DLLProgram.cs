using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.LinkedList
{
    public class DLLProgram : IProgram
    {
        public void Run()
        {
            int item;
            Console.WriteLine("-- Doubly Linked List --");
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                dll.Add(GenerateRandom());
            }
            dll.Print();
            Console.Write("Enter value to search: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contains {0} : {1}", item, dll.Contains(item));
            Console.Write("Enter value to delete: ");
            item = Convert.ToInt32(Console.ReadLine());
            dll.Delete(item);
            dll.Print();
        }

        public static int GenerateRandom()
        {
            var rand = new Random();
            return rand.Next(1, 999);
        }
    }
}
