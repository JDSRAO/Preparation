using CSharpSamples.DSAndAlgorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CSharpSamples.DSAndAlgorithms.Algorithms.Tests
{
    [TestFixture()]
    public class SortingAlgorithmsTests
    {
        [Test()]
        public void SimpleSortIntegerTest()
        {
            var actual = new List<int>() { 1, 3, 2, 5, 10 };
            var expected = new List<int>() { 10, 5, 3, 2, 1 };
            Assert.IsTrue(actual.SimpleSort().SequenceEqual(expected));
        }

        [Test()]
        public void SimpleSortCharTest()
        {
            var actual = new List<char>() { 'b', 'a', 'c' };
            var expected = new List<char> { 'c', 'b', 'a' };
            Assert.IsTrue(actual.SimpleSort().SequenceEqual(expected));
        }

        [Test()]
        public void SimpleSortOptimisedIntegerTest()
        {
            var actual = new List<int>() { 1, 3, 2, 5, 10 };
            var expected = new List<int>() { 1, 2, 3, 5, 10 };
            Assert.IsTrue(actual.SimpleSortOptimised().SequenceEqual(expected));
        }

        [Test()]
        public void SimpleSortOptimisedCharTest()
        {
            var actual = new List<char>() { 'b', 'a', 'c' };
            var expected = new List<char> { 'a', 'b', 'c' };
            Assert.IsTrue(actual.SimpleSortOptimised().SequenceEqual(expected));
        }

        [Test()]
        public void SelectionSortNullReferenceTest()
        {
            List<int> list = null;
            Assert.Throws<ArgumentNullException>(() => list.SelectionSort());
        }

        [Test()]
        public void SelectionSort__Item_Count_Test()
        {
            List<int> list = new List<int>() { 1, 3, 4,6, 6 };
            Assert.AreEqual(5, list.SelectionSort().Count);
        }

        [Test()]
        public void SelectionSortIntegerTest()
        {
            List<int> actual = new List<int>();
            actual.Add(10);
            actual.Add(1);
            actual.Add(3);
            actual.Add(9);
            actual.Add(0);
            var expected = new List<int> { 0, 1, 3, 9, 10 };
            Assert.IsTrue(actual.SelectionSort().SequenceEqual(expected));
        }

        [Test()]
        public void SelectionSortCharTest()
        {
            List<char> actual = new List<char>() { 'b', 'a' };
            var expected = new List<char> { 'a', 'b' };
            Assert.IsTrue(actual.SelectionSort().SequenceEqual(expected));
        }

        [Test()]
        public void BubbleSortIntegerTest()
        {
            var expected = new List<int>() { -1, 1, 5, };
            var actual = new List<int>() { 1, 5, -1, };
            Assert.IsTrue(actual.BubbleSort().SequenceEqual(expected));
        }

        [Test()]
        public void BubbleSortCharTest()
        {
            var expected = new List<int>() { 'a', 'b', 'i' };
            var actual = new List<int>() { 'b', 'a', 'i' };
            Assert.IsTrue(actual.BubbleSort().SequenceEqual(expected));
        }

        
    }
}