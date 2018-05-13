using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.BST
{
    public class BST<T> where T : struct
    {
        private BSNode<T> Root { get; set; }

        private int count;

        public int Count => count;

        public BST()
        {
            Root = null;
            count = 0;
        }

        public void Add(T item)
        {
            if (count == 0)
            {
                Root = new BSNode<T>(item);
            }
            else
            {
                AddNode(Root, item);
            }

            count++;
        }

        public bool Contains(T item)
        {
            var node = Root;
            if (node == null)
            {
                return false;
            }

            return Contains(node, item);
        }

        public void Print()
        {
            var node = Root;
        }

        private bool Contains(BSNode<T> node, T item)
        {
            if (Compare(node.Value, item) <= 0)
            {
                if (Equals(node.Value, item))
                {
                    return true;
                }
                else
                {
                    if (node.Right != null)
                    {
                        return Contains(node.Right, item);
                    }
                }
                
            }
            else
            {
                if (Equals(node.Value, item))
                {
                    return true;
                }
                else
                {
                    if (node.Left != null)
                    {
                        return Contains(node.Left, item);
                    }
                }
                
            }
            return false;
        }

        private void AddNode(BSNode<T> node, T item)
        {
            if (Compare(node.Value, item) < 0)
            {
                if (node.Right != null)
                {
                    AddNode(node.Right, item);
                }
                else
                {
                    node.Right = new BSNode<T>(item);
                }
                
            }
            else
            {
                if (node.Left != null)
                {
                    AddNode(node.Left, item);
                }
                else
                {
                    node.Left = new BSNode<T>(item);
                }
            }
        }

        private bool Equals(T item1, T item2)
        {
            if (Comparer<T>.Default.Compare(item1, item2) == 0)
            {
                return true;
            }
            return false;
        }

        private int Compare(T item1, T item2)
        {
            return Comparer<T>.Default.Compare(item1, item2);
        }
    }

    public class BSNode<T> where T : struct
    {
        public BSNode<T> Left { get; set; }

        public BSNode<T> Right { get; set; }

        public T Value { get; set; }

        public BSNode()
        {
            Left = null;
            Right = null;
            Value = default(T);
        }

        public BSNode(T item)
        {
            Left = null;
            Right = null;
            Value = item;
        }
    }
}
