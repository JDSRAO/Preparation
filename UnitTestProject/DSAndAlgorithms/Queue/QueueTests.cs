using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpSamples.DSAndAlgorithms.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSamples.DSAndAlgorithms.Queue.Tests
{
    [TestClass()]
    public class QueueTests
    {
        [TestMethod()]
        public void EnqueueTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod()]
        public void DequeueTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            Assert.AreEqual(1, queue.Count);
        }

        [TestMethod()]
        public void PeekTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            Assert.AreEqual(2, queue.Peek());
        }
    }
}