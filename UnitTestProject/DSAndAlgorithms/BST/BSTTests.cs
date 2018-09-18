using CSharpSamples.DSAndAlgorithms.BST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CSharpSamples.DSAndAlgorithms.BST.Tests
{
    [TestFixture()]
    public class BSTTests
    {
        [Test()]
        public void Add_Count_Test()
        {
            BST<int> bst = new BST<int>();
            bst.Add(1);
            bst.Add(2);
            Assert.AreEqual(2, bst.Count);
        }

        [Test()]
        public void Contains_Count_Test()
        {
            BST<int> bst = new BST<int>();
            bst.Add(1);
            bst.Add(2);
            Assert.IsTrue(bst.Contains(2));
            Assert.IsFalse(bst.Contains(3));
        }

        [Test()]
        public void Delete_Count_Test()
        {
            BST<int> bst = new BST<int>();
            bst.Add(3);
            bst.Add(2);
            bst.Delete(2);
            Assert.AreEqual(1, bst.Count);
        }

        [Test()]
        public void Delete_Item_Test()
        {
            int item = 2;
            BST<int> bst = new BST<int>();
            bst.Add(3);
            bst.Add(2);
            bst.Delete(item);
            Assert.IsFalse(bst.Contains(item), "Item deleted from BST");
        }
    }
}