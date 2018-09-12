using CSharpSamples.DSAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Queue
{
    /// <summary>
    /// Generic queue data structure
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    public class Queue<T> where T: struct
    {
        /// <summary>
        /// Count of items in the queue
        /// </summary>
        public int Count => llist.Count;

        /// <summary>
        /// Implementing the queue using a Linked list
        /// </summary>
        private DoublyLinkedList<T> llist = new DoublyLinkedList<T>();

        /// <summary>
        /// Add item to queue
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Enqueue(T item)
        {
            llist.Add(item);
        }

        /// <summary>
        /// Retrive item from the front of queue and return the same
        /// </summary>
        /// <returns>item at the front of queue</returns>
        public T Dequeue()
        {
            T value = llist.Head.Value;
            llist.Delete(llist.Head.Value);
            return value;
        }

        /// <summary>
        /// Retrive an item from the front withoud removing it
        /// </summary>
        /// <returns>Item at the front of the queue</returns>
        public T Peek()
        {
            return llist.Head.Value;
        }

        /// <summary>
        /// Convert the Queue to an array
        /// </summary>
        /// <returns>Array representaion of Queue</returns>
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
