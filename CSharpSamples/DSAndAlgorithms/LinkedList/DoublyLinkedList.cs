using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.LinkedList
{
    public class DoublyLinkedList<T> where T : struct
    {
        private DllNode<T> Head { get; set; }

        private DllNode<T> Tail { get; set; }

        private int count;

        public int Coount => count;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = Head;
            count = 0;
        }

        public void Add(T item)
        {
            var node = new DllNode<T>(item);
            if (count == 0)
            {
                Head = node;
                Tail = Head;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
            count++;
        }

        public void Print()
        {
            var node = Head;
            while (node.Next != null)
            {
                Console.Write("{0},", node.Value);
                if (node.Next == Tail)
                {
                    Console.Write("{0}", Tail.Value);
                }
                node = node.Next;
            }
            Console.WriteLine();
        }

        public bool Contains(T item)
        {
            var node = Head;
            while (node.Next != null)
            {
                if (Equals(node.Value, item))
                {
                    return true;
                }

                if (node.Next == Tail)
                {
                    if (Equals(Tail.Value, item))
                    {
                        return true;
                    }
                }
                node = node.Next;
            }
            return false;
        }

        public bool Delete(T item)
        {
            var node = Head;
            if (count == 0)
            {
                return false;
            }
            if (count == 1)
            {
                if (Equals(Head.Value, item))
                {
                    count--;
                    Head = null;
                    Tail = Head;
                    return true;
                }
            }

            while (node.Next != null)
            {
                if (Equals(node.Value, item))
                {
                    count--;
                    var nextNode = node.Next;
                    var previousNode = node.Previous;
                    if (previousNode != null)
                    {
                        previousNode.Next = nextNode;
                    }
                    else
                    {
                        Head = nextNode;
                    }

                    return true;
                }

                if (node.Next == Tail)
                {
                    if (Equals(Tail.Value, item))
                    {
                        count--;
                        node.Next = null;
                        Tail = node;
                        return true;
                    }
                }

                node = node.Next;
            }
            
            return false;
        }


        private static bool Equals(T item1, T item2)
        {
            if (Comparer<T>.Default.Compare(item1, item2) == 0)
            {
                return true;
            }
            return false;
        }
    }

    public class DllNode<T> where T : struct
    {
        public DllNode<T> Previous { get; set; }

        public DllNode<T> Next { get; set; }

        public T Value { get; set; }

        public DllNode()
        {
            Previous = null;
            Next = null;
            Value = default(T);
        }

        public DllNode(T item)
        {
            Value = item;
            Next = null;
            Previous = null;
        }
    }
}
