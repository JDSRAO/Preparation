using CSharpSamples.DSAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Queue
{
    public class Queue<T> where T: struct
    {
        public int Count => llist.Count;

        private DoublyLinkedList<T> llist = new DoublyLinkedList<T>();

        public void Enqueue(T item)
        {
            llist.Add(item);
        }

        public void Dequeue()
        {
            llist.Delete(llist.Head.Value);
        }

        public T Peek()
        {
            return llist.Head.Value;
        }

        public Array ToArray()
        {
            IList<T> list = new List<T>(llist.Count);
            var node = llist.Head;
            while(node.Next != null)
            {
                list.Add(node.Value);
            }
            return list.ToArray();
        }

    }
}
