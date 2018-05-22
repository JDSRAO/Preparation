using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.LinkedList
{
    public class SinglyLL<T> where T : struct
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        //public T this[int index] { get; set; }
        public int Count => count;

        private int count;

        public SinglyLL()
        {
            Head = new Node<T>();
            Tail = Head;
            count = 0;
        }

        public void Add(T item)
        {
            if(Equals(Head.Value, default(T)))
            {
                var node = new Node<T>(item);
                Tail.Next = node;
                Tail = node;
            }
            else
            {
                Head.Value = item;
                Head.Next = null;
            }
            count++;
        }

        public void Print()
        {
            Node<T> node = Head;
            while (node.Next != null)
            {
                Console.Write($"{node.Value}, ");
                if (node.Next == Tail)
                {
                    Console.Write($"{Tail.Value} ");
                }
                node = node.Next;
            }

            Console.WriteLine();
        }

        public bool Contains(T item)
        {
            var currentNode = Head;
            while (currentNode.Next != null)
            {
                if (Equals(currentNode.Value, item))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            if (Equals(currentNode.Value, item))
            {
                return true;
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
            else if (count == 1)
            {
                Head.Value = default(T);
                Tail = Head;
                count--;
                return true;
            }

            while (node.Next != null)
            {
                if (Equals(node.Value, item))
                {
                    count--;
                    var nextNode = node.Next;
                    node.Value = nextNode.Value;
                    node.Next = nextNode.Next;
                    return true;
                }

                if (node.Next == Tail)
                {
                    if (Equals(Tail.Value, item))
                    {
                        node.Next = null;
                        Tail = node;
                        count--;
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

    public class Node<T> where T : struct
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T item)
        {
            this.Value = item;
            Next = null;
        }

        public Node()
        {
            this.Value = default(T);
            Next = null;
        }
    }
}
