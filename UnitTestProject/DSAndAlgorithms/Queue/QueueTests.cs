using CSharpSamples.DSAndAlgorithms.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CSharpSamples.DSAndAlgorithms.Queue.Tests
{
    [TestFixture]
    public class QueueTests
    {
        [Test()]
        public void EnqueueTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            Assert.AreEqual(1, queue.Count);
        }

        [Test()]
        public void DequeueTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            Assert.AreEqual(1, queue.Count);
        }

        [Test()]
        public void PeekTest()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            Assert.AreEqual(2, queue.Peek());
        }
    }
}