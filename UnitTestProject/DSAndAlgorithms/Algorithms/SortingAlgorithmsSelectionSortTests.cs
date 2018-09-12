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
    public class SortingAlgorithmsSelectionSortTests
    {
        [Test()]
        public void SelectionSortNullReferenceTest()
        {
            List<int> list = null;
            Assert.Throws<ArgumentNullException>(() => list.SelectionSort());
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
            var expected = new List<int> { 0,1,3,9,10 };
            Assert.IsTrue(actual.SelectionSort().SequenceEqual(expected));
        }

        [Test()]
        public void SelectionSortCharTest()
        {
            List<char> actual = new List<char>() { 'b','a' };
            var expected = new List<char> { 'a', 'b' };
            Assert.IsTrue(actual.SelectionSort().SequenceEqual(expected));
        }
    }
}